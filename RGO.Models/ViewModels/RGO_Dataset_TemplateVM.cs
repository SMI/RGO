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
    public class RGO_Dataset_TemplateVM
    {
        public RGO_Dataset_Template? RGO_Dataset_Template { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem>? RGOutputList { get; set; }

        public IEnumerable<SelectListItem>? RGO_Release_StatusList { get; set; }
    }
}
