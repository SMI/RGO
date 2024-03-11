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
    public class RGO_EvidenceVM
    {
        public RGO_Evidence RGO_Evidence { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> EvidenceList { get; set; }
        public IEnumerable<SelectListItem> RGOutputList { get; set; }
    }
}
