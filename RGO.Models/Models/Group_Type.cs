using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using RGO.Models.Models;

namespace RGO.Models;

public class Group_Type
{
    [Key] public int Id { get; set; }

    [DisplayName("Group Type Name")] public string Name { get; set; } = "";


    /* Common Columns that should appear on all tables */

    [DisplayName("Input By")] public string Created_By { get; set; } = "";

    public DateTime Created_Date { get; set; } = DateTime.UtcNow;

    public string? Updated_By { get; set; }

    public DateTime? Updated_Date { get; set; }

    public string? Notes { get; set; }

    public ICollection<Group>? Group { get; set; }
}