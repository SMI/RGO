using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace RGO.Models.Models
{
    public class Group
    {
        [Key]
        public int Id { get; set; }


        public required int Group_TypeId { get; set; }  // Required Foreign Key Property
        /*[ForeignKey("Group_TypeId")]
        public virtual required Group_Type Group_Type { get; set; }*/
        public required Group_Type Group_Type { get; set; }

        [DisplayName("Group Name")]
        public required string Name { get; set; }

        [DisplayName("Contact Details")]
        public string? ContactInfo { get; set; }


        /* Common Columns that should appear on all tables */

        public required string Created_By { get; set; }

        public required DateTime Created_Date { get; set; }

        public string? Updated_By { get; set; }

        public DateTime? Updated_Date { get; set; }

        public string? Notes { get; set; }
    }
}
