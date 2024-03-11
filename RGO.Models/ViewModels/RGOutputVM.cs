using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using RGO.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGO.Models.ViewModels
{
    public class RGOutputVM
    {
        public RGOutput? RGOutput { get; set; }

        public IEnumerable<SelectListItem>? GroupList { get; set; }

        public IEnumerable<SelectListItem>? RGO_TypeList { get; set; }
        


    }
}
