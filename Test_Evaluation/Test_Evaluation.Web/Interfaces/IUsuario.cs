using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_Evaluation.Common.Entities;

namespace Test_Evaluation.Web.Interfaces
{
  public interface IUsuario
  {
    void AddUsuario(EntityUsuario entityUsuario);
    List<EntityUsuario> EntityUsuariosList();
  }
}
