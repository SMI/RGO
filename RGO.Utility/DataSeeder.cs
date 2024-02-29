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
        }
        // groups
        var groups = _unitOfWork.Group.GetAll();
        if(!groups.Any())
        {
            var group = new Group()
            {
                Created_By="seed",
                Created_Date= new DateTime(2024, 2, 20, 9, 2, 28, 43, DateTimeKind.Utc).AddTicks(2246),
                Group_TypeId=1,
                Name= "Classification of Brain Images"
            };
            _unitOfWork.Group.Add(group);
        }
        //RGOOutputs
        //migrationBuilder.InsertData(
        //    table: "RGOutputs",
        //    columns: new[] { "Id", "Created_By", "Created_Date", "Description", "Name", "Notes", "Originating_GroupId", "RGO_TypeId", "Updated_By", "Updated_Date" },
        //    values: new object[] { 1, "seed", new DateTime(2024, 2, 20, 9, 2, 28, 43, DateTimeKind.Utc).AddTicks(2366), "Brain Scan Classifications", "MRI Classification Group Truth", null, 1, 1, null, null });
        
        //dataset templates
        var datasetTemplates = _unitOfWork.RGO_Dataset_Template.GetAll();
        if(!datasetTemplates.Any())
        {
            var datasetTemplate = new RGO_Dataset_Template() {
                Created_By="seed",
                Created_Date= new DateTime(2024, 2, 20, 9, 2, 28, 43, DateTimeKind.Utc).AddTicks(2406),
                Description= "Classifying the type of Brain Scans, done by Gerry and Grant",
                Name = "MRI Classification Group Truth",
                RGOutput_Id=1
            };
            _unitOfWork.RGO_Dataset_Template.Add(datasetTemplate);

        }
        //column templates


        _unitOfWork.Save();


        //migrationBuilder.InsertData(
        //    table: "RGO_Column_Templates",
        //    columns: new[] { "Id", "Created_By", "Created_Date", "Description", "Name", "Notes", "PK_Column_Order", "Potentially_Disclosive", "RGO_Dataset_TemplateId", "Type", "Updated_By", "Updated_Date" },
        //    values: new object[,]
        //    {
        //        { 1, "seed", new DateTime(2024, 2, 20, 9, 2, 28, 43, DateTimeKind.Utc).AddTicks(2508), "Identifier of this image", "Image_Identifier", null, 1, "N", 1, "Int", null, null },
        //        { 2, "seed", new DateTime(2024, 2, 20, 9, 2, 28, 43, DateTimeKind.Utc).AddTicks(2512), "The ground truth that classifies the type of MRI this is e.g. T1, T2", "MRI_Classification", null, null, "N", 1, "Char", null, null },
        //        { 3, "seed", new DateTime(2024, 2, 20, 9, 2, 28, 43, DateTimeKind.Utc).AddTicks(2515), "An expert who generate this ground truth (1)", "Ground_Truther_1", null, null, "N", 1, "Int", null, null },
        //        { 4, "seed", new DateTime(2024, 2, 20, 9, 2, 28, 43, DateTimeKind.Utc).AddTicks(2518), "An expert who generate this ground truth (2)", "Ground_Truther_2", null, null, "N", 1, "Int", null, null },
        //        { 5, "seed", new DateTime(2024, 2, 20, 9, 2, 28, 43, DateTimeKind.Utc).AddTicks(2521), "The date on which this Ground Truth was finalised", "Date_GT_Recorded", null, null, "N", 1, "Date", null, null }
        //    });
    }
}
