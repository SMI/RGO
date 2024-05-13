using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace RGO.Models.Models
{
    public class RGO_Column
    {
        [Key]
        public int Id { get; set; }

        public int RGO_RecordId { get; set; }
        [DisplayName("Which RGO Record does this column belong to")]
        [ForeignKey("RGO_RecordId")]
        public RGO_Record? RGO_Record { get; set; }

        public int RGO_Column_TemplateId { get; set; }
        [DisplayName("Which RGO Column Template is this based on")]
        [ForeignKey("RGO_Column_TemplateId")]
        public RGO_Column_Template? RGO_Column_Template { get; set; }


        [DisplayName("Column Name")]
        public string? Name { get; set; }

        [DisplayName("If this is a PK column, which position is it")]
        public int? PK_Column_Order { get; set; }

        [DisplayName("Column Type")]
        public string? Type { get; set; }

        [DisplayName("Potentially Disclosive? (N or a description)")]
        public string? Potentially_Disclosive { get; set; }

        [DisplayName("Column Value")]
        public string? Column_Value { get; set; }

        public int IsIdentifier { get; set; } = 0;


        /* Common Columns that should appear on all tables */

        [DisplayName("Input By")] public string? Created_By { get; set; } = "";

        public DateTime Created_Date { get; set; } = DateTime.UtcNow;

        public string? Updated_By { get; set; }

        public DateTime? Updated_Date { get; set; }

        public string? Notes { get; set; }
    }
}
