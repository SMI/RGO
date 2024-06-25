using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace RGO.Models.Models
{
    public class RGO_Dataset_Template
    {
        [Key]
        public int Id { get; set; }

        public int RGOutput_Id { get; set; }
        [DisplayName("Parent RG Output")]
        [ForeignKey("RGOutput_Id")]
        public RGOutput? RGOutput { get; set; }


        [DisplayName("Dataset Template")]
        public string Name { get; set; } = "";

        [DisplayName("Dataset Template Description")]
        public string? Description { get; set; }

        public int Release_Status_Id { get; set; }
        [DisplayName("Initial Release Status (can be overriden for individual datasets)")]
        [ForeignKey("Release_Status_Id")]
        public RGO_Release_Status? RGO_Release_Status { get; set; }

        public ICollection<Models.RGO_Column_Template>? RGO_Column_Template { get; set; }

        public ICollection<Models.RGO_Dataset>? RGO_Dataset { get; set; }


        /* Common Columns that should appear on all tables */

        [DisplayName("Input By")] public string? Created_By { get; set; } = "";

        [DisplayName("Created Date")] public DateTime Created_Date { get; set; } = DateTime.Now;

        [DisplayName("Updated By")] public string? Updated_By { get; set; }

        [DisplayName("Updated Date")] public DateTime? Updated_Date { get; set; }

        public string? Notes { get; set; }

    }
}
