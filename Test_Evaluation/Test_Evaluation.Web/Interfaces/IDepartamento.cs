using System.Collections.Generic;
using System.Threading.Tasks;
using Test_Evaluation.Common.Entities;
using Test_Evaluation.Web.Helpers;

namespace Test_Evaluation.Web.Interfaces
{
  public interface IDepartamento
  {
    Task<List<EntityDepartamento>> ListDepartamentoAsync();
    HelperResponse SelectDepartamentoById(EntityDepartamento entityDepartamento);
    void AddDepartamento(EntityDepartamento entityDepartamento);
    EntityDepartamento SelectEntityDepartamentobyId(int codigo);
    void EditDepartamento(EntityDepartamento entityDepartamento);
    Task DeleteDepartamento(int? codigo);

  }
}
