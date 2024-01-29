using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace RGO.Models
{
    public class Group_Type
    {
        [Key]
        public int Id { get; set; }


        [MaxLength(20)]
        [DisplayName("Group Type Name")]
        public required string Name { get; set; }


        /* Common Columns that should appear on all tables */

        public required string Created_By { get; set; }

        public required DateTime Created_Date { get; set; }

        public string? Updated_By { get; set; }

        public DateTime? Updated_Date { get; set; }

        public string? Notes { get; set; }


    }
}
