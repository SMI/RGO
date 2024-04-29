using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using RGO.Models.Models;
using System.Text.RegularExpressions;

namespace RGO.Models
{
    public class RGO_Release_Status
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(20)]
        public string Name { get; set; } = "";


        public string Description { get; set; } = "";

        [MaxLength(3)]
        public String Available_For_Release { get; set; } = "N";


        /* Common Columns that should appear on all tables */

        public string Created_By { get; set; } = "";

        public DateTime Created_Date { get; set; } = DateTime.UtcNow;

        public string? Updated_By { get; set; }

        public DateTime? Updated_Date { get; set; }

        public string? Notes { get; set; }

        public ICollection<Models.RGO_Dataset_Template>? RGO_Dataset_Template { get; set; }

        public ICollection<Models.RGO_Column_Template>? RGO_Column_Template { get; set; }

        public ICollection<Models.RGO_Dataset>? RGO_Dataset { get; set; }

    }
}
