using Microsoft.AspNetCore.Mvc;
using RGO.DataAccess.Repository;
using RGO.DataAccess.Repository.IRepository;
using RGO.Models;
using RGO.Models.Models;
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
            List<RGO_Dataset> objGroupTypeList = _unitOfWork.RGO_Dataset.GetAll().ToList();
            return Json(new { data = objGroupTypeList });
        }

        public IActionResult Download(int id)
        {
            RGO_Dataset dataset = _unitOfWork.RGO_Dataset.GetAll().Where(ds => ds.Id == id).First();
            var net = new System.Net.WebClient();
            var data = Encoding.ASCII.GetBytes("this is some data");
            var content = new System.IO.MemoryStream(data);
            var contentType = "APPLICATION/octet-stream";
            var fileName = "test.csv";
            return File(content, contentType, fileName);

        }

        #endregion

    }
}
