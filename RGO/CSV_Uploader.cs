using Microsoft.VisualBasic.FileIO;
using RGO.DataAccess.Data;
using RGO.DataAccess.Repository;
using RGO.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGO
{
    public class CSV_Uploader
    {
        private string _filePath;
        private int _datasetTemplateId;
        private int _datasetId;
        private int _recordId;
        private ApplicationDbContext _context;
        private RGO_Dataset_Template _datasetTemplate;



        public void ExecuteUpload()
        {
            //string inputFile = @"C:\Temp\RGO_2.csv";
            //var uploader = new CSV_Uploader("C:\RGX_2.csv");

            if (PreCheck().Equals(true))
            {

                createDatasetRecord();

                RGO_RecordRepository recrepo = new RGO_RecordRepository(_context);
                RGO_ColumnRepository colrepo = new RGO_ColumnRepository(_context);
                RGO_Record_PersonRepository rprepo = new RGO_Record_PersonRepository(_context);

                int recordIndex = 0;
                List<string> columnHeaders = new List<string>();

                int columnIndex = 0;
                List<string> columnValues = new List<string>();


                foreach (var line in File.ReadLines(_filePath))
                {
                    if (recordIndex == 0)
                    {
                        //Grab the column headers
                        line.Split(",").ToList().ForEach(columnHeaders.Add);



                    }
                    else
                    {
                        // Create a RGO_Record record for each non-header row

                        RGO_Record recrec = new RGO_Record();

                        recrec.RGO_DatasetId = _datasetId;
                        recrec.Created_By = "RGO_Upload";
                        recrec.Record_Status = "Uploading";
                        recrepo.Add(recrec);

                        _context.SaveChanges();
                        _recordId = recrec.Id;

                        // Grab the column values for this record
                        line.Split(",").ToList().ForEach(columnValues.Add);



                        //Loop through the columns in column headers
                        foreach (var header in columnHeaders)
                        {

                            var _colRepository = new RGO_Column_TemplateRepository(_context);
                            //var _columnTemplate = _colRepository.GetAll().Where(r => r.Id.Equals(_DatasetTemplateId) && r.Name == header).FirstOrDefault();
                            var _columnTemplate = _colRepository.GetAll().Where(r => r.Id.Equals(_datasetTemplateId)).FirstOrDefault();

                            if (!header.StartsWith("Ground_Truther"))
                            {
                                // Create a new RGO_Column Record
                                RGO_Column colrec = new RGO_Column();

                                colrec.RGO_RecordId = recrec.Id;
                                colrec.Name = header;
                                colrec.PK_Column_Order = _columnTemplate.PK_Column_Order;
                                colrec.Type = _columnTemplate.Type;
                                colrec.Potentially_Disclosive = _columnTemplate.Potentially_Disclosive;
                                colrec.Column_Value = columnValues[columnIndex];
                                colrec.Column_Status = "Uploading";
                                colrec.Created_By = "RGO_Upload";
                                //colrec.Created_Date = DateTime.Now;

                                colrepo.Add(colrec);


                            } else
                            {
                                //Find the id of the person record with this name

                                var _personRepository = new PersonRepository(_context);
                                var _person = _personRepository.GetAll().Where(pr => pr.Name.Equals(columnValues[columnIndex])).FirstOrDefault();

                                // Create a new RGO_Person_Record Record
                                RGO_Record_Person rprec = new RGO_Record_Person();


                                rprec.RGO_RecordId = recrec.Id;
                                rprec.PersonId = _person.Id;
                                rprec.Person_Record_Role = "Ground Truther";
                                rprec.Created_By = "RGO_Upload";
                                //rprec.Created_Date = DateTime.Now;

                                rprepo.Add(rprec);
                            }
                            
                            _context.SaveChanges();

                            columnIndex++;

                        }


                    }

                    recordIndex++; 
                }

                _context.SaveChanges();

            }
        }

        public CSV_Uploader(string filePath)
        {
            _filePath = filePath;

        } 

        public bool PreCheck()
        {
            if (!File.Exists(_filePath)) return false;
            var _fileInfo = new FileInfo(_filePath);
            var _fileName = _fileInfo.FullName;
            var _fileNameNoExt = Path.GetFileNameWithoutExtension(_fileName);
            if (!_fileNameNoExt.StartsWith("RGO_")) return false;
            var datasetTemplateId = _fileNameNoExt.Substring(4);

            var applicationContext = new ApplicationDbContextFactory();
            _context = applicationContext.CreateDbContext(new string[] {});

            var _repository = new RGO_Dataset_TemplateRepository(_context);

            //var datasetTemplate = _repository.FirstOrDefault(r => r.Id.Equals(int.Parse(datasetTemplateId)));//

            _datasetTemplateId = int.Parse(datasetTemplateId);
            _datasetTemplate = _repository.GetAll().Where(r => r.Id.Equals(_datasetTemplateId)).FirstOrDefault();

            if (_datasetTemplate == null) { return false; }

            return true;
        }

        public bool createDatasetRecord()
        {
            RGO_Dataset dsrec = new RGO_Dataset();

            dsrec.RGO_Dataset_TemplateId = _datasetTemplateId;
            dsrec.Dataset_Name  = _datasetTemplate.Name;
            dsrec.Dataset_Status = "Uploading";
            dsrec.Created_By = "RGO_Upload";
            //dsrec.Created_Date = DateTime.Now;

            RGO_DatasetRepository dsrepo = new RGO_DatasetRepository(_context);
            dsrepo.Add(dsrec);
            _context.SaveChanges();

            _datasetId = dsrec.Id;

            return true;
        }

    }
}
