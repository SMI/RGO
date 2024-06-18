using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace RGO.Models
{
    public class Evidence
    {
        [Key]
        public int Id { get; set; }

        public int Evidence_TypeId { get; set; }
        [ForeignKey("Evidence_TypeId")]

        public Evidence_Type? Evidence_Type { get; set; }

        [DisplayName("Evidence Name")]
        public string Name { get; set; } = "";

        [DisplayName("Evidence Details")]
        public string? EvidenceDetails { get; set; }


        [DisplayName("Digital Object Id (DOI)")]
        public string? Doi { get; set; }

        // Standard Acknowledgement Text moved to RGO_Evidence at JK's instruction (SL 17/06/2024)

        public ICollection<RGO_Evidence>? RGO_Evidence { get; set; }


        /* Common Columns that should appear on all tables */

        [DisplayName("Input By")] public string? Created_By { get; set; } = "";

        public DateTime Created_Date { get; set; } = DateTime.UtcNow;

        public string? Updated_By { get; set; }

        public DateTime? Updated_Date { get; set; }

        public string? Notes { get; set; }
    }
}
