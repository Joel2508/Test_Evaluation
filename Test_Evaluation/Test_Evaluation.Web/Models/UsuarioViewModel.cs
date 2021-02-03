using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Test_Evaluation.Common.Entities;

namespace Test_Evaluation.Web.Models
{
  public class UsuarioViewModel:EntityUsuario
  {
    [Display(Name = "Cargo")]
    [Range(1, int.MaxValue, ErrorMessage = "Debes selecionar un tipo de cargo.")]
    public int CargoId { get; set; }

    public IEnumerable<SelectListItem> Cargo { get; set; }



    [Display(Name = "Departamento")]
    [Range(1, int.MaxValue, ErrorMessage = "Debes selecionar un tipo de departamento.")]
    public int DepartamentoId { get; set; }

    public IEnumerable<SelectListItem> Departamento { get; set; }
  }
}
