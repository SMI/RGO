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
    public class GroupVM
    {
        public required Group Group { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> Group_TypeList { get; set; } 
    }
}
