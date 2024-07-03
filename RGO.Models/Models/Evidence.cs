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


        
        [ForeignKey("Evidence_TypeId")]
        [DisplayName("Evidence Type")]
        public int Evidence_TypeId { get; set; }
        [DisplayName("Evidence Type")]
        public Evidence_Type? Evidence_Type { get; set; }

        [DisplayName("Details")]
        public string Name { get; set; } = "";

        [DisplayName("Additional Info")]
        public string? EvidenceDetails { get; set; }


        [DisplayName("Evidence DOI")]
        public string? Doi { get; set; }

        // Standard Acknowledgement Text moved to RGO_Evidence at JK's instruction (SL 17/06/2024)

        public ICollection<RGO_Evidence>? RGO_Evidence { get; set; }


        /* Common Columns that should appear on all tables */

        [DisplayName("Input By")] public string? Created_By { get; set; } = "";

        [DisplayName("Created Date")] public DateTime Created_Date { get; set; } = DateTime.Now;

        [DisplayName("Updated By")] public string? Updated_By { get; set; }

        [DisplayName("Updated Date")] public DateTime? Updated_Date { get; set; }

        public string? Notes { get; set; }
    }
}
