using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace RGO.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Person Name")]
        public string Name { get; set; } = "";

        [DisplayName("Contact Details")]
        public string? ContactInfo { get; set; }

        [DisplayName("ORCID")]
        public string? OrcId { get; set; }

        public ICollection<Models.RGO_Record_Person>? RGO_Record_Person { get; set; }


        /* Common Columns that should appear on all tables */

        [DisplayName("Input By")] public string? Created_By { get; set; } = "";

        public DateTime Created_Date { get; set; } = DateTime.UtcNow;

        public string? Updated_By { get; set; }

        public DateTime? Updated_Date { get; set; }

        public string? Notes { get; set; }
    }
}
