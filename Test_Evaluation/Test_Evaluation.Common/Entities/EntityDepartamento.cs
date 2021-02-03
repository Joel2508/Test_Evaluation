using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Test_Evaluation.Common.Entities
{
  public class EntityDepartamento
  {
    [Key]
    public int Codigo { get; set; }
    public string Nombre { get; set; }    
  }
}
