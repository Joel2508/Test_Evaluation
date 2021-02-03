using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test_Evaluation.Web.Interfaces
{
  public interface ICombo
  {
    IEnumerable<SelectListItem> SelectListItemsDepartamento();
    IEnumerable<SelectListItem> SelectListItemsCargo();
  }
}
