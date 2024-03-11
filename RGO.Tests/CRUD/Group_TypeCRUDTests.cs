using Microsoft.EntityFrameworkCore;
using RGO.DataAccess.Data;
using RGO.DataAccess.Repository;
using RGO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGO.Tests.CRUD
{
    public class Group_TypeCRUDTests
    {
        private UnitOfWork _UnitOfWork;
        private int newPK;

        [SetUp]
        public void Setup()
        {

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            

            /* Tell JRF to fix this */

            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=R-GO;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

            var dbContext = new ApplicationDbContext(optionsBuilder.Options);

            _UnitOfWork = new UnitOfWork(dbContext);

            
            
        }

        [Test]
        public void Create_Test()
        {

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

        }

        [Test]
        public void Create_Test_Invalid_Data()
        {

            try
            {
                Group_Type group_type = new Group_Type();

                _UnitOfWork.Group_Type.Add(group_type);

                group_type.Name = "Unit Test Group Type LONG";
                group_type.Created_By = "NUNIT";


                _UnitOfWork.Save();

                newPK = group_type.Id;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("We expected this to fail");
                Assert.Pass();
            }
            Console.WriteLine("This insert should have failed as the input data is invalid!");
            Assert.Fail();

        }
    }
}