using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_Evaluation.Common.Entities;
using Test_Evaluation.Web.Data;

namespace Test_Evaluation.Web.Interfaces
{
  public class Usuario : IUsuario
  {
    private readonly DataContext dataContext;

    public Usuario(DataContext dataContext)
    {
      this.dataContext = dataContext;
    }
    public void AddUsuario(EntityUsuario entityUsuario)
    {
      dataContext.EntityUsuarios.Add(entityUsuario);
      dataContext.SaveChanges();
    }

    public List<EntityUsuario> EntityUsuariosList()
    {
      return dataContext.EntityUsuarios.ToList();
    }
  }
}
