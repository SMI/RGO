using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using RGO.Models.Models;
using System.Text.RegularExpressions;

namespace RGO.Models
{
    public class RGO_Type
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(20)]
        [DisplayName("RGO Type")]
        public string Name { get; set; } = "";

        [DisplayName("RGO Type Description")]
        public string? Description { get; set; }

        /* Common Columns that should appear on all tables */

        [DisplayName("Input By")] public string? Created_By { get; set; } = "";

        [DisplayName("Created Date")] public DateTime Created_Date { get; set; } = DateTime.Now;

        [DisplayName("Updated By")] public string? Updated_By { get; set; }

        [DisplayName("Updated Date")] public DateTime? Updated_Date { get; set; }

        public string? Notes { get; set; }



        public ICollection<RGOutput>? RGOutput { get; set; }


    }
}
