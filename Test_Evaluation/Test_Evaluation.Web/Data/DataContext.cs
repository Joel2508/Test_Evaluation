using Microsoft.EntityFrameworkCore;
using Test_Evaluation.Common.Entities;

namespace Test_Evaluation.Web.Data
{
  public class DataContext : DbContext
  {
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {

    }
    public DbSet<EntityCargo> EntityCargos { get; set; }
    public DbSet<EntityDepartamento> EntityDepartamentos { get; set; }

    public DbSet<EntityUsuario> EntityUsuarios { get; set; }
  }
}
