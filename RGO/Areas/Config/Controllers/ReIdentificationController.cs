using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Migrations;
using RGO.DataAccess.Repository.IRepository;

namespace RGO.Areas.Config.Controllers
{
    public class ReIdentificationController : Controller
    {

        private readonly IUnitOfWork _unitOfWork;

        public ReIdentificationController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
//migrationBuilder.CreateTable(
//   name: "RGO_ReIdentificationConfiguration",
//   columns: table => new
//   {
//       Id = table.Column<int>(type: "int", nullable: false)
//           .Annotation("SqlServer:Identity", "1, 1"),
//       Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
//       Server = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
//       Database = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
//       Table = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
//       DeIdentificationColumn = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
//       IdentityColumn = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
//       Username = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
//       Password = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
//   },
//   constraints: table =>
//   {
//       table.PrimaryKey("PK_ReIdentificationConfiguration", x => x.Id);
//   });