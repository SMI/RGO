using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RGO.Models.Models;

public class Group
{
    [Key] public int Id { get; set; }
    public int Group_TypeId { get; set; }
    [ForeignKey("Group_TypeId")] public Group_Type? Group_Type { get; set; }


    [DisplayName("Group Name")] public string Name { get; set; } = "";

    [DisplayName("Lead Author (If supplied)")]
    public string? ContactInfo { get; set; }

    [DisplayName("Reference Number")] public string? Reference_number { get; set; }

    public ICollection<RGOutput>? RGOutput { get; set; }

    /* Common Columns that should appear on all tables */

    [DisplayName("Input By")] public string Created_By { get; set; } = "";

    public DateTime Created_Date { get; set; } = DateTime.UtcNow;

    public string? Updated_By { get; set; }

    public DateTime? Updated_Date { get; set; }

    public string? Notes { get; set; }
}