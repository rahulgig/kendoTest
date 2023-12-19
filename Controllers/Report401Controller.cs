using kendoTest.Models;
using Microsoft.AspNetCore.Mvc;

namespace kendoTest.Controllers
{
    public class Report401Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult RequestForm()
        {
            Report401ViewModel model = new()
            {
                MLPFormNo = 401,
                FormName = "माग फाराम"
            };
            return View(model);
        }

        [HttpGet]
        public JsonResult Offices()
        {
            List<object> officeList =
            [
                new { text = "Kathmandu", value = "Kathmandu" },
                new { text = "Lalitpur", value = "Lalitpur" },
                new {text = "Ilam", value="Ilam"}
            ];
            return Json(officeList);
        }




        [HttpPost]
        public IActionResult RequestForm(Report401ViewModel requestForm)
        {


            Console.WriteLine(requestForm.ToString());
            return Ok(requestForm);
            
        }
    }
}
