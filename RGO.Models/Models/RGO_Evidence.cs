using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using static System.Net.Mime.MediaTypeNames;

namespace RGO.Models
{
    public class RGO_Evidence
    {
        [Key]
        public int Id { get; set; }

        public int Evidence_Id { get; set; }
        [ForeignKey("Evidence_Id")]

        public Evidence? Evidence { get; set; }

        public int RGOutput_Id { get; set; }
        [ForeignKey("RGOutput_Id")]

        public RGOutput? RGOutput { get; set; }

        //Standard Acknowledgement Text moved from Evidence at JK's instruction (SL 17/06/2024)
        [DisplayName("Standard Acknowledgement Text")]
        public string? StandardAcknowledgement { get; set; }

        /* Common Columns that should appear on all tables */

        [DisplayName("Input By")] public string? Created_By { get; set; } = "";

        [DisplayName("Created Date")] public DateTime Created_Date { get; set; } = DateTime.Now;

        [DisplayName("Updated By")] public string? Updated_By { get; set; }

        [DisplayName("Updated Date")] public DateTime? Updated_Date { get; set; }

        public string? Notes { get; set; }

    }
}
