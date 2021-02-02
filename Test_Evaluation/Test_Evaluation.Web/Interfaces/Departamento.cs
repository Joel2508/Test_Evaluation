using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_Evaluation.Common.Entities;
using Test_Evaluation.Web.Data;
using Test_Evaluation.Web.Helpers;

namespace Test_Evaluation.Web.Interfaces
{
  public class Departamento : IDepartamento
  {
    private readonly DataContext dataContext;

    public Departamento(DataContext dataContext)
    {
      this.dataContext = dataContext;
    }
    public void AddDepartamento(EntityDepartamento entityDepartamento)
    {
      dataContext.EntityDepartamentos.Add(entityDepartamento);
       dataContext.SaveChanges();
    }

    public async Task DeleteDepartamento(int? codigo)
    {
      var finbyIdDepartamento = dataContext.EntityDepartamentos.Find(codigo);
      dataContext.EntityDepartamentos.Remove(finbyIdDepartamento);
      await dataContext.SaveChangesAsync();
    }

    public void EditDepartamento(EntityDepartamento entityDepartamento)
    {
      dataContext.Entry(entityDepartamento).State = EntityState.Modified;
      dataContext.SaveChanges();
    }

    public async Task<List<EntityDepartamento>> ListDepartamentoAsync()
    {
      var list = await dataContext.EntityDepartamentos.OrderBy(d=>d.Nombre).ToListAsync();
      return list;
    }

    public  HelperResponse SelectDepartamentoById(EntityDepartamento entityDepartamento)
    {
      var selectDepartamento =  dataContext.EntityDepartamentos.FirstOrDefault(d => d.Nombre == entityDepartamento.Nombre);
      if (selectDepartamento != null)
      {
        return new HelperResponse
        {
          Isucces = false,
          Message = "no puedes agregarlo, se encuentra registrado",
        };
      }
      return new HelperResponse
      {
        Isucces = true,
        Message ="Ok"
      };
    }

    public EntityDepartamento SelectEntityDepartamentobyId(int codigo)
    {
      return dataContext.EntityDepartamentos.FirstOrDefault(d => d.Codigo == codigo);
    }
  }
}
