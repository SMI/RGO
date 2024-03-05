using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using NUnit.Framework.Constraints;
using RGO;
using RGO.DataAccess.Data;
using RGO.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGO.Tests.CSVUpload
{
    public  class CSVUploadUploadTests
    {
        private UnitOfWork _UnitOfWork;

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
        public void FileExistsTest()
        {

            var uploader = new CSV_Uploader(@"C:/Temp/RGO_1.csv", _UnitOfWork);

            Assert.That(uploader.PreCheck(), Is.EqualTo(true));  // check that the input file exists, and there is a matching RGO_Dataset_Template in the db


            Assert.Pass();
            //myCsv.Dispose();
        }

        [Test]
        public void ExecuteUpload()
        {

            var uploader = new CSV_Uploader(@"C:/Temp/RGO_1.csv",_UnitOfWork);

            uploader.ExecuteUpload();

            Assert.Pass();
            //myCsv.Dispose();
        }
    }
}
