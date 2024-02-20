using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace RGO.Models.Models
{
    public class RGO_Dataset
    {
        [Key]
        public int Id { get; set; }

        public int RGO_Dataset_TemplateId { get; set; }
        [DisplayName("Which RGO Dataset Template is this based on")]
        [ForeignKey("RGO_Dataset_TemplateId")]
        public RGO_Dataset_Template? RGO_Dataset_Template { get; set; }


        [DisplayName("Dataset Name")]
        public string? Dataset_Name { get; set; }


        [DisplayName("Dataset Status")]
        public string Dataset_Status { get; set; } = "New";


        /* Common Columns that should appear on all tables */

        public string Created_By { get; set; } = "";

        public DateTime Created_Date { get; set; } = DateTime.UtcNow;

        public string? Updated_By { get; set; }

        public DateTime? Updated_Date { get; set; }

        public string? Notes { get; set; }
    }
}
