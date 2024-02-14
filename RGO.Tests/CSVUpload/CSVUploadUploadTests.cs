using Microsoft.VisualBasic;
using NUnit.Framework.Constraints;
using RGO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGO.Tests.CSVUpload
{
    public  class CSVUploadUploadTests
    {

        [Test]
        public void FileExistsTest()
        {

            var uploader = new CSV_Uploader(@"C:/Temp/RGO_1.csv");

            Assert.That(uploader.PreCheck(), Is.EqualTo(true));  // check that the input file exists, and there is a matching RGO_Dataset_Template in the db


            Assert.Pass();
            //myCsv.Dispose();
        }

        [Test]
        public void ExecuteUpload()
        {

            var uploader = new CSV_Uploader(@"C:/Temp/RGO_1.csv");

            uploader.ExecuteUpload();

            Assert.Pass();
            //myCsv.Dispose();
        }
    }
}
