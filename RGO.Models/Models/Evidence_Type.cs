using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using RGO.Models.Models;
using System.Text.RegularExpressions;

namespace RGO.Models
{
    public class Evidence_Type
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        [DisplayName("Evidence Type Name")]
        public string Name { get; set; } = "";

        public string Description { get; set; } = "";

        public ICollection<Evidence>? Evidence { get; set; }

        /* Common Columns that should appear on all tables */

        public string Created_By { get; set; } = "";

        public DateTime Created_Date { get; set; } = DateTime.UtcNow;

        public string? Updated_By { get; set; }

        public DateTime? Updated_Date { get; set; }

        public string? Notes { get; set; }




    }
}
