using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace RGO.Models.Models
{
    public class RGO_Column_Template
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Which RGO Dataset Template is this part of")]
        public int RGO_Dataset_TemplateId { get; set; }
        [ForeignKey("RGO_Dataset_TemplateId")]


        public RGO_Dataset_Template RGO_Dataset_Template { get; set; }

        [DisplayName("Column Name")]
        public string Name { get; set; } = "";

        [DisplayName("Column Description")]
        public string? Description { get; set; }

        [DisplayName("If this is a PK column, please indicate the order")]
        public int? PK_Column_Order { get; set; }

        [DisplayName("Column Type")]
        public string Type { get; set; } = "";

        [DisplayName("Potentially Disclosive? (N or a description)")]
        public string Potentially_Disclosive { get; set; } = "N";

        public int IsIdentifier { get; set; } = 0;

        /* Common Columns that should appear on all tables */

        public string Created_By { get; set; } = "";

        public DateTime Created_Date { get; set; } = DateTime.UtcNow;

        public string? Updated_By { get; set; }

        public DateTime? Updated_Date { get; set; }

        public string? Notes { get; set; }

    }
}
