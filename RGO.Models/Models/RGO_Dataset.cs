using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace RGO.Models.Models
{
    public class RGO_Dataset
    {
        [Key]
        public int Id { get; set; }

        public int RGO_Dataset_TemplateId { get; set; }
        [DisplayName("Based on RGO Dataset Template")]
        [ForeignKey("RGO_Dataset_TemplateId")]
        public RGO_Dataset_Template? RGO_Dataset_Template { get; set; }


        [DisplayName("Dataset Name (to distinguish instances of the same dataset)")]
        public string? Dataset_Name { get; set; }


        [DisplayName("Digital Object Id (DOI)")]
        public string? Doi { get; set; }


        [DisplayName("Dataset Status")]
        public string Dataset_Status { get; set; } = "New";

        public int? RGO_ReIdentificationConfigurationId { get; set; }
        [DisplayName("ReIdentification Configuration")]
        [ForeignKey("RGO_ReIdentificationConfigurationId")]
        public RGO_ReIdentificationConfiguration? RGO_ReIdentificationConfiguration { get; set; }

        public int Release_Status_Id { get; set; }
        [DisplayName("Release Status")]
        [ForeignKey("Release_Status_Id")]
        public RGO_Release_Status? RGO_Release_Status { get; set; }

        public ICollection<Models.RGO_Record>? RGO_Record { get; set; }    

        /* Common Columns that should appear on all tables */

        public string Created_By { get; set; } = "";

        [DisplayName("Date loaded into RGO")]
        public DateTime Created_Date { get; set; } = DateTime.UtcNow;

        public string? Updated_By { get; set; }

        public DateTime? Updated_Date { get; set; }

        public string? Notes { get; set; }


    }
}
