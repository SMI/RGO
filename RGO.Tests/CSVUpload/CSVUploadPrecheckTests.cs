using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using NUnit.Framework.Constraints;
using RGO.DataAccess.Data;
using RGO.DataAccess.Repository;
using RGO.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGO.Tests.CSVUpload
{
    public class CSVUploadPrecheckTests
    {
        private UnitOfWork _UnitOfWork;

        [SetUp]
        public void Setup() {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            /* Tell JRF to fix this */
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=R-GO;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

            var dbContext =  new ApplicationDbContext(optionsBuilder.Options);
            _UnitOfWork = new UnitOfWork(dbContext);
        }

        [Test]
        public void GoodCSVUploadTest()
        {
            var myCsv = File.Create("RGO_1.csv");
            
            var uploader = new CSV_Uploader("RGO_1.csv", _UnitOfWork);

            Assert.That(uploader.PreCheck(), Is.EqualTo(true));


            Assert.Pass();
            myCsv.Dispose();
        }

        [Test]
        public void BadNameCSVUploadTest()
        {
            var myCsv = File.Create("RGX_2.csv");

            var uploader = new CSV_Uploader("RGX_2.csv",_UnitOfWork);

            Assert.That(uploader.PreCheck(), Is.EqualTo(false));


            Assert.Pass();
            myCsv.Dispose();
        }

    }


}
