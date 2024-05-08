using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

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

        /* Common Columns that should appear on all tables */

        [DisplayName("Input By")] public string Created_By { get; set; } = "";

        public DateTime Created_Date { get; set; } = DateTime.UtcNow;

        public string? Updated_By { get; set; }

        public DateTime? Updated_Date { get; set; }

        public string? Notes { get; set; }
    }
}
