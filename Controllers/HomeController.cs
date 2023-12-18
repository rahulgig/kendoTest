using kendoTest.Models;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace kendoTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult NewPage()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        /*[HttpGet]
        public JsonResult GetData()
        {
            DataModel dm = new DataModel { id = 1 , name="ek"};
            DataModel dm2 = new DataModel { id = 2, name = "dui" };

            List<DataModel> dataSet = new List<DataModel> { dm, dm2};
            

            return Json(dataSet);
        }*/
        [HttpPost]

        public JsonResult CollectHtml(string editorData)
        {
            Console.WriteLine(editorData);
            return Json(editorData);
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
