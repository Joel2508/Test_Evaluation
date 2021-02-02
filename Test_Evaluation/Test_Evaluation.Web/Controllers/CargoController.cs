using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_Evaluation.Common.Entities;
using Test_Evaluation.Web.Interfaces;

namespace Test_Evaluation.Web.Controllers
{
  public class CargoController : Controller
  {
    private readonly ICargo cargo;

    public CargoController(ICargo cargo)
    {
      this.cargo = cargo;
    }

    public ActionResult Index()
    {
      return View(cargo.ListCargo());
    }

    public ActionResult AddCargo()
    {
      return View();
    }

    [HttpPost]
    public ActionResult AddCargo(EntityCargo Entitycargo)
    {
      try
      {
        if (ModelState != null)
        {
          var select = cargo.SelectCargobyId(Entitycargo);
          if (!select.Isucces)
          {
            ModelState.AddModelError(string.Empty, "El cargo " + Entitycargo.Nombre + " " + select.Message);
            return View();
          }

          if (Entitycargo != null)
          {
            cargo.AddCargo(Entitycargo);
          }
          return RedirectToAction("Index");
        }

      }
      catch (Exception)
      {
        return null;
      }

      return View();
    }


    public ActionResult EditCargo(int? id)
    {

      if (id == null)
      {
        return NotFound();
      }
      var editcargoSelect = cargo.SelectEntityCargobyId(Convert.ToInt32(id));
      if (editcargoSelect ==null)
      {
        return NotFound();
      }
      return View(editcargoSelect);
    }


    [HttpPost]
    public IActionResult EditCargo(EntityCargo entityCargo)
    {
      if (ModelState.IsValid)
      {
        var selectCargo = cargo.SelectCargobyId(entityCargo);
        if (!selectCargo.Isucces)
        {
          ModelState.AddModelError(string.Empty, "El cargo " + entityCargo.Nombre + " " + selectCargo.Message);
          return View();
        }
        cargo.EditCargo(entityCargo);        
      }
      return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> DeleteCargo (int? id)
    {
      if (id == null)
      {
        return NotFound();
      }
      await cargo.DeleteCargo(id);
      return RedirectToAction(nameof(Index));
    }

  }

}
