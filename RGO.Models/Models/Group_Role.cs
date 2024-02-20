using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace RGO.Models.Models
{
    public class Group_Role
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Role Name")]
        public string Name { get; set; } = "";

        [DisplayName("Role Description")]
        public string? Description { get; set; }

        /* Common Columns that should appear on all tables */

        public string Created_By { get; set; } = "";

        public DateTime Created_Date { get; set; } = DateTime.UtcNow;

        public string? Updated_By { get; set; }

        public DateTime? Updated_Date { get; set; }

        public string? Notes { get; set; }
    }
}
