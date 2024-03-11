using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace RGO.Models.Models
{
    public class Group
    {
        [Key]
        public int Id { get; set; }

        public int Group_TypeId { get; set; }
        [ForeignKey("Group_TypeId")]

        public Group_Type? Group_Type { get; set; }

        [DisplayName("Group Name")]
        public string Name { get; set; } = "";

        [DisplayName("Contact Details")]
        public string? ContactInfo { get; set; }

        public ICollection<RGOutput>? RGOutput { get; set; }


        /* Common Columns that should appear on all tables */

        public string Created_By { get; set; } = "";

        public DateTime Created_Date { get; set; } = DateTime.UtcNow;

        public string? Updated_By { get; set; }

        public DateTime? Updated_Date { get; set; }

        public string? Notes { get; set; }
    }
}
