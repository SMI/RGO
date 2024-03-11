using Microsoft.AspNetCore.Mvc;
using RGO.DataAccess.Repository;
using RGO.DataAccess.Repository.IRepository;
using RGO.Models;
using RGO.Models.Models;
using RGO.Utility;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace RGO.Areas.Config.Controllers
{
    [Area("Config")]
    public class DatasetsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public DatasetsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            List<RGO_Dataset> objList = _unitOfWork.RGO_Dataset.GetAll().ToList();
            return View(objList);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        #region API CALLS

        [HttpGet]
        public IActionResult GetAll()
        {
            List<RGO_Dataset> objRGO_DatasetList = _unitOfWork.RGO_Dataset.GetAll().ToList();
            return Json(new { data = objRGO_DatasetList });
        }


        [HttpPatch]
        public IActionResult SetReIdentificationConfiguration(int datasetId,int reidentificationId)
        {
            RGO_Dataset dataset= _unitOfWork.RGO_Dataset.GetAll().Where(ds => ds.Id == datasetId).First();
            dataset.RGO_ReIdentificationConfigurationId = reidentificationId;
            _unitOfWork.RGO_Dataset.Update(dataset);
            _unitOfWork.Save();
            return Json(new { data = dataset });
        }

        public IActionResult Download(int id)
        {
            RGO_Dataset dataset = _unitOfWork.RGO_Dataset.GetAll().Where(ds => ds.Id == id).First();
            var exporter = new RGO_DatasetExporter(_unitOfWork, dataset);
            
            var data = Encoding.ASCII.GetBytes(exporter.GenerateExportableData());
            var content = new MemoryStream(data);
            var contentType = "APPLICATION/octet-stream";
            var fileName = "test.csv";
            return File(content, contentType, fileName);

        }

        #endregion

    }
}
