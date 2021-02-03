using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_Evaluation.Common.Entities;
using Test_Evaluation.Web.Models;

namespace Test_Evaluation.Web.Interfaces
{
  public class Converte : IConverte
  {
    public EntityUsuario ConverteUsario(UsuarioViewModel usuarioViewModel)
    {
      return new EntityUsuario
      {
        Apellido = usuarioViewModel.Apellido,
        Nombre = usuarioViewModel.Nombre,
        FechaNacimiento = usuarioViewModel.FechaNacimiento,
        Cedula = usuarioViewModel.Cedula,
        Cargos = usuarioViewModel.Cargos,
        Departamentos = usuarioViewModel.Departamentos,
        Usuario = usuarioViewModel.Usuario,
      };
    }
  }
}
