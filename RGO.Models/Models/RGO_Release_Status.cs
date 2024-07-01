using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using RGO.Models.Models;

namespace RGO.Models;

public class RGO_Release_Status
{
    [Key] public int Id { get; set; }

    [DisplayName("Release Status")][MaxLength(250)] public string Name { get; set; } = "";

    [DisplayName("Release Status Description")] public string? Description { get; set; } = "";

    [DisplayName("Available for researchers")]
    public string Available_For_Release { get; set; } = "N";


    /* Common Columns that should appear on all tables */

    [DisplayName("Input By")] public string? Created_By { get; set; } = "";

    [DisplayName("Created Date")] public DateTime Created_Date { get; set; } = DateTime.Now;

    [DisplayName("Updated By")] public string? Updated_By { get; set; }

    [DisplayName("Updated Date")] public DateTime? Updated_Date { get; set; }

    public string? Notes { get; set; }


    public ICollection<RGO_Dataset_Template>? RGO_Dataset_Template { get; set; }

    public ICollection<RGO_Column_Template>? RGO_Column_Template { get; set; }

    public ICollection<RGO_Dataset>? RGO_Dataset { get; set; }
}