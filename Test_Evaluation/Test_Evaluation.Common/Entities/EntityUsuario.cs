using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Test_Evaluation.Common.Entities
{
  
  public class EntityUsuario
  {
    [Key]
    public int Usuario { get; set; }
    public string Cedula { get; set; }

    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string FechaNacimiento { get; set; }

    [Display(Name = "Cargo")]
    public IEnumerable<EntityCargo> Cargos { get; set; }

    [Display(Name = "Departamento")]
    public IEnumerable<EntityDepartamento> Departamentos { get; set; }
  }
}
