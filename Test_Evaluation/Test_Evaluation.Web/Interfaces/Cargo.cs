using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_Evaluation.Common.Entities;
using Test_Evaluation.Web.Data;
using Test_Evaluation.Web.Helpers;

namespace Test_Evaluation.Web.Interfaces
{

  public class Cargo : ICargo
  {
    private DataContext dataContext;
    public Cargo(DataContext dataContext)
    {
      this.dataContext = dataContext;
    }
    public EntityCargo AddCargo(EntityCargo entityCargo)
    {
      try
      {
        if (entityCargo != null)
        {
          dataContext.EntityCargos.Add(entityCargo);
          dataContext.SaveChanges();
          return entityCargo;
        }

      }
      catch
      {
        return null;
      }
      return null;
    }

    public async Task<HelperResponse> DeleteCargo(int? id)
    {
      var selectDelete = await dataContext.EntityCargos.FindAsync(id);
      if (selectDelete != null)
      {
         dataContext.EntityCargos.Remove(selectDelete);
        await dataContext.SaveChangesAsync();
        return new HelperResponse
        {
          Isucces = true,
          Message = "Se elimino correctamente."
        
        };
      }
      return new HelperResponse
      {
        Isucces = false,
        Message = "No se elimino"
      };      
    }

    public void EditCargo(EntityCargo entityCargo)
    {
      dataContext.Entry(entityCargo).State = EntityState.Modified;
      dataContext.SaveChanges();
    }

    public List<EntityCargo> ListCargo()
    {
      return dataContext.EntityCargos.OrderBy(c=>c.Nombre).ToList();
    }

    public HelperResponse SelectCargobyId(EntityCargo entityCargo)
    {
      var selectcargo = dataContext.EntityCargos.FirstOrDefault(c => c.Nombre == entityCargo.Nombre);
      if (selectcargo != null)
      {
        return new HelperResponse
        {
          Message = "no puedes agregarlo, se encuentra registrado",
          Isucces = false,
        };
      }
      return new HelperResponse
      {
        Isucces = true,
        Message = "Ok",
      };
    }

    public EntityCargo SelectEntityCargobyId(int cargo)
    {
      return dataContext.EntityCargos.FirstOrDefault(c => c.Cargo == cargo);
    }
  }
}
