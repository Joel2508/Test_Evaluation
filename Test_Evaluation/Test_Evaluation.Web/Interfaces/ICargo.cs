using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_Evaluation.Common.Entities;
using Test_Evaluation.Web.Helpers;

namespace Test_Evaluation.Web.Interfaces
{
  public interface ICargo
  {
    EntityCargo AddCargo(EntityCargo entityCargo);
    void EditCargo(EntityCargo entityCargo);
    Task<HelperResponse> DeleteCargo(int? id);

    List<EntityCargo> ListCargo();
    HelperResponse SelectCargobyId(EntityCargo entityCargo);
    EntityCargo SelectEntityCargobyId(int cargo);
  }
}
