using Microsoft.EntityFrameworkCore;
using RGO.DataAccess.Data;
using RGO.DataAccess.Repository;
using RGO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XunitTests.CRUD
{

    //Test naming convention Class_Method_ExpectedResult
    public static void Group_Type_Add_Sucess();
    {
        private UnitOfWork _UnitOfWork;
        private int newPK;

        try 
        {
        //Arrange - go get your variables, classes, etc
        var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();


        /* Tell JRF to fix this */

        optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=R-GO;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        var dbContext = new ApplicationDbContext(optionsBuilder.Options);

        _UnitOfWork = new UnitOfWork(dbContext);


        //Act - Execute this function
        try
            {
                Group_Type group_type = new Group_Type();
                _UnitOfWork.Group_Type.Add(group_type);

                group_type.Name = "Unit Test Group Type";
                group_type.Created_By = "NUNIT";

                _UnitOfWork.Save();
                newPK = group_type.Id;

            }
            catch (Exception e)
            {
                Console.WriteLine("Insert Test Failed");
                Assert.Fail();
            }
                Console.WriteLine("Insert Test Passed");
                Assert.Pass();

        //Assert - does the returned (actual) value match the expected value

    }
}
