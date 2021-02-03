using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_Evaluation.Common.Entities;
using Test_Evaluation.Web.Models;

namespace Test_Evaluation.Web.Interfaces
{
  public interface IConverte
  {
    EntityUsuario ConverteUsario(UsuarioViewModel usuarioViewModel);
  }
}
