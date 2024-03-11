using RGO.DataAccess.Data;
using RGO.DataAccess.Repository;
using RGO.Models;
using RGO.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGO.Utility;

public class DataSeeder
{
    private UnitOfWork _unitOfWork;

    public DataSeeder(ApplicationDbContext db) {
        _unitOfWork = new UnitOfWork(db);
    }


    public void Seed()
    {
        //groupTypes
        var groupTypes = _unitOfWork.Group_Type.GetAll();
        if(!groupTypes.Any()) {
            var seedGroupType = new Group_Type()
            {
                Created_By="seed",
                Created_Date= new DateTime(2024, 2, 20, 9, 2, 28, 43, DateTimeKind.Utc).AddTicks(1982),
                Name = "Research Group"

            };
            _unitOfWork.Group_Type.Add(seedGroupType);
            seedGroupType = new Group_Type()
            {
                Created_By = "seed",
                Created_Date = new DateTime(2024, 2, 20, 9, 2, 28, 43, DateTimeKind.Utc).AddTicks(1986),
                Name = "Data Team"

            };
            _unitOfWork.Group_Type.Add(seedGroupType);
            _unitOfWork.Save();
        }
        //People
        var people = _unitOfWork.Person.GetAll();
        if (!people.Any())
        {
            var seedPerson = new Person()
            {
                ContactInfo="Argus@dundee.ac.uk",
                Created_By="seed",
                Created_Date = new DateTime(2024, 2, 20, 9, 2, 28, 43, DateTimeKind.Utc).AddTicks(2289),
                Name="Argus Argive",
                Notes= "Academic Neuroradiologist",
                OrcId="123ABC"
            };
            _unitOfWork.Person.Add(seedPerson);
            seedPerson = new Person()
            {
                ContactInfo = "Euphemus@dundee.ac.uk",
                Created_By = "seed",
                Created_Date = new DateTime(2024, 2, 20, 9, 2, 28, 43, DateTimeKind.Utc).AddTicks(2293),
                Name = "Euphemus Calydonian",
                Notes = "Senior Clinical Lecturer in Neuroradiology",
                OrcId = "456DEF"
            };
            _unitOfWork.Person.Add(seedPerson);
            seedPerson = new Person()
            {
                ContactInfo = "Idmon@dundee.ac.uk",
                Created_By = "seed",
                Created_Date = new DateTime(2024, 2, 20, 9, 2, 28, 43, DateTimeKind.Utc).AddTicks(2296),
                Name = "Idmon Argos",
                Notes = "Postdoctoral Researcher",
                OrcId = ""
            };
            _unitOfWork.Person.Add(seedPerson);
            seedPerson = new Person()
            {
                ContactInfo = "Jason@dundee.ac.uk",
                Created_By = "seed",
                Created_Date = new DateTime(2024, 2, 20, 9, 2, 28, 43, DateTimeKind.Utc).AddTicks(2298),
                Name = "Jason Iolcus",
                Notes = "EPCC Applications Developer",
                OrcId = ""
            };
            _unitOfWork.Person.Add(seedPerson);
            _unitOfWork.Save();
        }
        //RGO Types
        var RGOTypes = _unitOfWork.RGO_Type.GetAll();
        if (!RGOTypes.Any())
        {
            var rgoType = new RGO_Type()
            {
                Created_By="seed",
                Created_Date= new DateTime(2024, 2, 20, 9, 2, 28, 43, DateTimeKind.Utc).AddTicks(2335),
                Description= "Annotations that have been manually created or validated by a human expert",
                Name="Ground Truth"
            };
            _unitOfWork.RGO_Type.Add(rgoType);
            _unitOfWork.Save();
        }
        // groups
        var groups = _unitOfWork.Group.GetAll();
        if(!groups.Any())
        {
            var group = new Group()
            {
                Created_By="seed",
                Created_Date= new DateTime(2024, 2, 20, 9, 2, 28, 43, DateTimeKind.Utc).AddTicks(2246),
                Group_Type= _unitOfWork.Group_Type.GetAll().First() ,
                Name= "Classification of Brain Images"
            };
            _unitOfWork.Group.Add(group);
            _unitOfWork.Save();
        }
        //RGOOutputs
        var outputs = _unitOfWork.RGO_Output.GetAll();
        if (!outputs.Any())
        {
            var output = new RGOutput() { 
                Created_By="seed",
                Created_Date= new DateTime(2024, 2, 20, 9, 2, 28, 43, DateTimeKind.Utc).AddTicks(2366),
                Description= "Brain Scan Classifications",
                Name= "MRI Classification Group Truth",
                RGO_Type= _unitOfWork.RGO_Type.GetAll().First(),
                Originating_GroupId= _unitOfWork.Group.GetAll().First().Id,
            };
            _unitOfWork.RGO_Output.Add(output);
            _unitOfWork.Save();
        }
  
        //dataset templates
        var datasetTemplates = _unitOfWork.RGO_Dataset_Template.GetAll();
        if(!datasetTemplates.Any())
        {
            var datasetTemplate = new RGO_Dataset_Template() {
                Created_By="seed",
                Created_Date= new DateTime(2024, 2, 20, 9, 2, 28, 43, DateTimeKind.Utc).AddTicks(2406),
                Description= "Classifying the type of Brain Scans, done by Gerry and Grant",
                Name = "MRI Classification Group Truth",
                RGOutput_Id= _unitOfWork.RGO_Output.GetAll().First().Id,
            };
            _unitOfWork.RGO_Dataset_Template.Add(datasetTemplate);
            _unitOfWork.Save();

        }
        //column templates
        var columnTemplates = _unitOfWork.RGO_Column_Template.GetAll();
        if (!columnTemplates.Any())
        {
            var columnTemplate = new RGO_Column_Template()
            {
                Created_By="seed",
                Created_Date = new DateTime(2024, 2, 20, 9, 2, 28, 43, DateTimeKind.Utc).AddTicks(2508),
                Description= "Identifier of this image",
                Name="Image_Identifier",
                PK_Column_Order=1,
                Potentially_Disclosive="N",
                RGO_Dataset_TemplateId=_unitOfWork.RGO_Dataset_Template.GetAll().First().Id,
                Type="Int",
                IsIdentifier=1
                
            };
            _unitOfWork.RGO_Column_Template.Add(columnTemplate);
            columnTemplate = new RGO_Column_Template()
            {
                Created_By = "seed",
                Created_Date = new DateTime(2024, 2, 20, 9, 2, 28, 43, DateTimeKind.Utc).AddTicks(2512),
                Description = "The ground truth that classifies the type of MRI this is e.g. T1, T2",
                Name = "MRI_Classification",
                PK_Column_Order = 1,
                Potentially_Disclosive = "N",
                RGO_Dataset_TemplateId = _unitOfWork.RGO_Dataset_Template.GetAll().First().Id,
                Type = "Char"
            };
            _unitOfWork.RGO_Column_Template.Add(columnTemplate);
            columnTemplate = new RGO_Column_Template()
            {
                Created_By = "seed",
                Created_Date = new DateTime(2024, 2, 20, 9, 2, 28, 43, DateTimeKind.Utc).AddTicks(2515),
                Description = "An expert who generate this ground truth (1)",
                Name = "Ground_Truther_1",
                PK_Column_Order = 1,
                Potentially_Disclosive = "N",
                RGO_Dataset_TemplateId = _unitOfWork.RGO_Dataset_Template.GetAll().First().Id,
                Type = "Int"
            };
            _unitOfWork.RGO_Column_Template.Add(columnTemplate);
            columnTemplate = new RGO_Column_Template()
            {
                Created_By = "seed",
                Created_Date = new DateTime(2024, 2, 20, 9, 2, 28, 43, DateTimeKind.Utc).AddTicks(2518),
                Description = "An expert who generate this ground truth (2)",
                Name = "Ground_Truther_2",
                PK_Column_Order = 1,
                Potentially_Disclosive = "N",
                RGO_Dataset_TemplateId = _unitOfWork.RGO_Dataset_Template.GetAll().First().Id,
                Type = "Int"
            };
            _unitOfWork.RGO_Column_Template.Add(columnTemplate);
            columnTemplate = new RGO_Column_Template()
            {
                Created_By = "seed",
                Created_Date = new DateTime(2024, 2, 20, 9, 2, 28, 43, DateTimeKind.Utc).AddTicks(2521),
                Description = "The date on which this Ground Truth was finalised",
                Name = "Date_GT_Recorded",
                PK_Column_Order = 1,
                Potentially_Disclosive = "N",
                RGO_Dataset_TemplateId = _unitOfWork.RGO_Dataset_Template.GetAll().First().Id,
                Type = "Date"
            };
            _unitOfWork.RGO_Column_Template.Add(columnTemplate);
            _unitOfWork.Save();
        }
    }
}
