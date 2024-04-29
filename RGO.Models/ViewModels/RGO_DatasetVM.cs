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
    public class RGO_DatasetVM
    {
        public RGO_Dataset RGO_Dataset { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> RGO_Dataset_TemplateList { get; set; }

        public IEnumerable<SelectListItem> RGO_ReIdentificationConfigurationList { get; set; }

        public IEnumerable<SelectListItem> RGO_Release_StatusList { get; set; }
    }
}
