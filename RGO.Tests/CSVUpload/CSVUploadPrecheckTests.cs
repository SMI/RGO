using Microsoft.VisualBasic;
using NUnit.Framework.Constraints;
using RGO.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGO.Tests.CSVUpload
{
    public  class CSVUploadPrecheckTests
    {

        [Test]
        public void GoodCSVUploadTest()
        {
            var myCsv = File.Create("RGO_1.csv");
            
            var uploader = new CSV_Uploader("RGO_1.csv");

            Assert.That(uploader.PreCheck(), Is.EqualTo(true));


            Assert.Pass();
            myCsv.Dispose();
        }

        [Test]
        public void BadNameCSVUploadTest()
        {
            var myCsv = File.Create("RGX_2.csv");

            var uploader = new CSV_Uploader("RGX_2.csv");

            Assert.That(uploader.PreCheck(), Is.EqualTo(false));


            Assert.Pass();
            myCsv.Dispose();
        }

    }


}
