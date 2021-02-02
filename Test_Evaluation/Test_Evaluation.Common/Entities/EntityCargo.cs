using System.ComponentModel.DataAnnotations;

namespace Test_Evaluation.Common.Entities
{
  public class EntityCargo
  {
    [Key]
    public int Cargo { get; set; }

    public string Nombre { get; set; }

  }
}
