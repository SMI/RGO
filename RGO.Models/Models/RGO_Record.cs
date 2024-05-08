using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace RGO.Models.Models
{
    public class RGO_Record
    {
        [Key]
        public int Id { get; set; }

        public int RGO_DatasetId { get; set; }
        [DisplayName("Which RGO Dataset does this record belong to")]
        [ForeignKey("RGO_DatasetId")]
        public RGO_Dataset? RGO_Dataset { get; set; }


        //[DisplayName("Record Status")]
        //public string Record_Status { get; set; } = "New";

        public ICollection<RGO_Record_Person>? RGO_Record_Person { get; set; }


        /* Common Columns that should appear on all tables */

        [DisplayName("Input By")] public string Created_By { get; set; } = "";

        public DateTime Created_Date { get; set; } = DateTime.UtcNow;

        public string? Updated_By { get; set; }

        public DateTime? Updated_Date { get; set; }

        public string? Notes { get; set; }
    }
}
