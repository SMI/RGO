using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using RGO.Models.Models;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations.Schema;
using Group = RGO.Models.Models.Group;

namespace RGO.Models
{
    public class RGOutput
    {
        [Key]
        public int Id { get; set; }

        public int RGO_TypeId { get; set; }
        [ForeignKey("RGO_TypeId")]
        public RGO_Type? RGO_Type { get; set; }

        [DisplayName("RGO Name")]
        public string Name { get; set; } = "";

        [DisplayName("RGO Description")]
        public string? Description { get; set; }

        [DisplayName("Originating Group")]
        public int Originating_GroupId { get; set; }
        [ForeignKey("Originating_GroupId")]
        public Group? Group { get; set; }

        public ICollection<RGO_Dataset_Template>? RGO_Dataset_Template { get; set; }

        /* Common Columns that should appear on all tables */

        public string Created_By { get; set; } = "";

        public DateTime Created_Date { get; set; } = DateTime.UtcNow;

        public string? Updated_By { get; set; }

        public DateTime? Updated_Date { get; set; }

        public string? Notes { get; set; }



    }
}
