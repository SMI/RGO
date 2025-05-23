﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using RGO.Models.Models;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations.Schema;
using Group = RGO.Models.Models.Group;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace RGO.Models
{
    public class RGOutput
    {
        [Key]
        public int Id { get; set; }


        
        
        [ForeignKey("RGO_TypeId")]
        [DisplayName("RGO Type")]
        public int RGO_TypeId { get; set; }
        [DisplayName("RGO Type")]
        public RGO_Type? RGO_Type { get; set; }


        [DisplayName("RGO Name")]
        public string Name { get; set; } = "";

        [DisplayName("RGO Description")]
        public string? Description { get; set; }

        [DisplayName("Originating Group")]
        [ForeignKey("Originating_GroupId")]
        public int Originating_GroupId { get; set; }
        [DisplayName("Originating Group")]
        public Group? Group { get; set; }

        [DisplayName("RG Output DOI")]
        public string? Doi { get; set; }

        [DisplayName("RG Output Acknowledgement Text")]
        public string? StandardAcknowledgement { get; set; }

        public ICollection<RGO_Dataset_Template>? RGO_Dataset_Template { get; set; }
        public ICollection<RGO_Evidence>? RGO_Evidence { get; set; }

        /* Common Columns that should appear on all tables */

        [DisplayName("Input By")] public string? Created_By { get; set; } = "";

        [DisplayName("Created Date")] public DateTime Created_Date { get; set; } = DateTime.Now;

        [DisplayName("Updated By")] public string? Updated_By { get; set; }

        [DisplayName("Updated Date")] public DateTime? Updated_Date { get; set; }

        public string? Notes { get; set; }




    }
}
