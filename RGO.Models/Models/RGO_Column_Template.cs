﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace RGO.Models.Models
{
    public class RGO_Column_Template
    {
        [Key]
        public int Id { get; set; }


        public int RGO_Dataset_TemplateId { get; set; }
        [DisplayName("Which RGO Dataset Template is this part of")]
        [ForeignKey("RGO_Dataset_TemplateId")]
        public RGO_Dataset_Template? RGO_Dataset_Template { get; set; }

        [DisplayName("Column Name")]
        public string Name { get; set; } = "";

        [DisplayName("Column Description")]
        public string? Description { get; set; }

        [DisplayName("If this is a PK column, please indicate the order")]
        public int? PK_Column_Order { get; set; }

        [DisplayName("Column Type (Number, Text or Date)")]
        public string Type { get; set; } = "";

        [DisplayName("Potentially Disclosive? (N or a description)")]
        public string Potentially_Disclosive { get; set; } = "N";

        public int IsIdentifier { get; set; } = 0;

        public int Release_Status_Id { get; set; }
        [DisplayName("Is this a releasable column? - applies to all records based on this template")]
        [ForeignKey("Release_Status_Id")]
        public RGO_Release_Status? RGO_Release_Status { get; set; }

        public ICollection<Models.RGO_Column>? RGO_Column { get; set; }

        public ICollection<Models.RGO_Record_Person>? RGO_Record_Person { get; set; }

        /* Common Columns that should appear on all tables */

        [DisplayName("Input By")] public string? Created_By { get; set; } = "";

        [DisplayName("Created Date")] public DateTime Created_Date { get; set; } = DateTime.Now;

        [DisplayName("Updated By")] public string? Updated_By { get; set; }

        [DisplayName("Updated Date")] public DateTime? Updated_Date { get; set; }

        public string? Notes { get; set; }




    }
}
