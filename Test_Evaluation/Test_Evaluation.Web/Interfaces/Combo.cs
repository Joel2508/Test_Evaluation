using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_Evaluation.Web.Data;

namespace Test_Evaluation.Web.Interfaces
{
  public class Combo : ICombo
  {
    private readonly DataContext dataContext;

    public Combo(DataContext dataContext)
    {
      this.dataContext = dataContext;
    }

    public IEnumerable<SelectListItem> SelectListItemsCargo()
    {
      var list = dataContext.EntityCargos.Select(c => new SelectListItem
      {
        Text = c.Nombre,
        Value = c.Cargo.ToString()
      }).OrderBy(l => l.Text).ToList();
      list.Insert(0, new SelectListItem
      {
        Text = "[Select lessee...]",
        Value = "0"
      });
      return list;
    }

    public IEnumerable<SelectListItem> SelectListItemsDepartamento()
    {
      var list = dataContext.EntityDepartamentos.Select(d => new SelectListItem
      {
        Text = d.Nombre,
        Value = d.Codigo.ToString()
      }).OrderBy(l => l.Text).ToList();
      list.Insert(0, new SelectListItem
      {
        Text = "[Select lessee...]",
        Value = "0"
      });
      return list;

    }
  }
}
