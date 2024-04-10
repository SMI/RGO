using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace RGO.Models.Models
{
    public class RGO_Record_Person
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Person Id")]
        public int PersonId { get; set; }
        [ForeignKey("PersonId")]
        public Person? Person { get; set; }

        public int RGO_Column_TemplateId { get; set; }
        [DisplayName("Which RGO Column Template is this based on")]
        [ForeignKey("RGO_Column_TemplateId")]
        public RGO_Column_Template? RGO_Column_Template { get; set; }

        [DisplayName("RGO Record Id")]
        public int RGO_RecordId { get; set; }
        [ForeignKey("RGO_RecordId")]
        public RGO_Record? RGO_Record { get; set; }


        [DisplayName("Person Record Role")]
        public string? Person_Record_Role { get; set; }


        /* Common Columns that should appear on all tables */

        public string Created_By { get; set; } = "";

        public DateTime Created_Date { get; set; } = DateTime.UtcNow;

        public string? Updated_By { get; set; }

        public DateTime? Updated_Date { get; set; }

        public string? Notes { get; set; }
    }
}
