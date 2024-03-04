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
    public class RGO_Column_TemplateVM
    {
        public RGO_Column_Template? RGO_Column_Template { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem>? RGO_Dataset_TemplateList { get; set; }
    }
}
