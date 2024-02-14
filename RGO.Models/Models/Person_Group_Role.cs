using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace RGO.Models.Models
{
    public class Person_Group_Role
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Group Id")]
        public int Group_Id { get; set; }
        [ForeignKey("Group_Id")]
        public Group? Group { get; set; }

        [DisplayName("Person Id")]
        public int Person_Id { get; set; }
        [ForeignKey("Person_Id")]
        public Person? Person { get; set; }

        [DisplayName("Group Role Id")]
        public int Group_Role_Id { get; set; }
        [ForeignKey("Group_Role_Id")]
        public Group_Role? Group_Role { get; set; }

        [DisplayName("Start Date")]
        public DateTime? Start_Date { get; set; }

        [DisplayName("End Date")]
        public DateTime? End_Date { get; set; }


        /* Common Columns that should appear on all tables */

        public string Created_By { get; set; } = "";

        public DateTime Created_Date { get; set; } = DateTime.UtcNow;

        public string? Updated_By { get; set; }

        public DateTime? Updated_Date { get; set; }

        public string? Notes { get; set; }
    }
}
