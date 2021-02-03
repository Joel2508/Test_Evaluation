using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Test_Evaluation.Web.Data;
using Test_Evaluation.Web.Interfaces;
using Test_Evaluation.Web.Models;

namespace Test_Evaluation.Web.Controllers
{
  public class UsuarioController : Controller
  {    
    private readonly IUsuario usuario;
    private readonly ICombo combo;
    private readonly IConverte converte;

    public UsuarioController(IUsuario usuario, ICombo combo, IConverte converte)
    {
      this.usuario = usuario;
      this.combo = combo;
      this.converte = converte;
    }

    public IActionResult Index()
    {
      return View(usuario.EntityUsuariosList());
    }

    public IActionResult AddUsuario()
    {

      var usuario = new UsuarioViewModel();
      usuario.Cargo = combo.SelectListItemsCargo();

      usuario.Departamento = combo.SelectListItemsDepartamento();
      return View(usuario);
    }

    [HttpPost]
    public IActionResult AddUsuario(UsuarioViewModel usuarioViewModel)
    {

      if (usuarioViewModel != null)
      {
        var usuarioConverte = converte.ConverteUsario(usuarioViewModel);
        usuario.AddUsuario(usuarioConverte);
      }
      return View(usuario);
    }

  }
}
