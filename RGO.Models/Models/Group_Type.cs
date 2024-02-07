using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using RGO.Models.Models;
using System.Text.RegularExpressions;

namespace RGO.Models
{
    public class Group_Type
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(20)]
        [DisplayName("Group Type Name")]
        public string Name { get; set; } = "";


        /* Common Columns that should appear on all tables */

        public string Created_By { get; set; } = "";

        public DateTime Created_Date { get; set; } = DateTime.UtcNow;

        public string? Updated_By { get; set; }

        public DateTime? Updated_Date { get; set; }

        public string? Notes { get; set; }


    }
}
