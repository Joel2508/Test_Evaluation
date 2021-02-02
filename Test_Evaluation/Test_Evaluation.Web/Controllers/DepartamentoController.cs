using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_Evaluation.Common.Entities;
using Test_Evaluation.Web.Interfaces;

namespace Test_Evaluation.Web.Controllers
{
  public class DepartamentoController : Controller
  {
    private readonly IDepartamento departamento;

    public DepartamentoController(IDepartamento departamento)
    {
      this.departamento = departamento;
    }

    public async Task<IActionResult> Index()
    {
      return View(await departamento.ListDepartamentoAsync());
    }

    public IActionResult AddDepartamento()
    {
      return View();
    }
    [HttpPost]
    public IActionResult AddDepartamento(EntityDepartamento entityDepartamento)
    {

      if (ModelState.IsValid)
      {
        try
        {
          if (entityDepartamento != null)
          {
            var selectDepartamento = departamento.SelectDepartamentoById(entityDepartamento);
            if (!selectDepartamento.Isucces)
            {
              ModelState.AddModelError(string.Empty, "El departamento " + entityDepartamento.Nombre + " " + selectDepartamento.Message);
              return View();
            }
            departamento.AddDepartamento(entityDepartamento);
            return RedirectToAction(nameof(Index));
          }
        }
        catch (Exception)
        {
          return null;
        }

      }
      return View();
    }


    public IActionResult EditDepartamento(int? id)
    {
      if (id == null)
      {
        return NotFound();
      }
      var selectDepartamento = departamento.SelectEntityDepartamentobyId(Convert.ToInt32(id));
      if (selectDepartamento == null)
      {
        return NotFound();
      }
      return View(selectDepartamento);
    }

    [HttpPost]
    public IActionResult EditDepartamento(EntityDepartamento entityDepartamento)
    {
      if (ModelState.IsValid)
      {
        var selectDepartamento = departamento.SelectDepartamentoById(entityDepartamento);
        if (!selectDepartamento.Isucces)
        {
          ModelState.AddModelError(string.Empty, "El departamento " + entityDepartamento.Nombre + " " + selectDepartamento.Message);
          return View();
        }
        departamento.EditDepartamento(entityDepartamento);
      }
      return RedirectToAction(nameof(Index));
    }
   
    public async  Task<IActionResult> DeleteDepartamento(int? id)
    {
      if (id == null)
      {
        return NotFound();
      }
      await departamento.DeleteDepartamento(id);
      return RedirectToAction(nameof(Index));
    }

  }
}
