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
            Report401Model model = new Report401Model();
            return View(model);
        }

        [HttpGet]
        public JsonResult Offices()
        {
            List<object> officeList = new List<object>
            {
                new { text = "Kathmandu", value = "Kathmandu" },
                new { text = "Lalitpur", value = "Lalitpur" },
                new {text = "Ilam", value="Ilam"}
            };
            return Json(officeList);
        }



        [HttpPost]
        public IActionResult RequestForm(Report401Model requestForm)
        {

            Console.WriteLine(requestForm.ToString());
            return Ok(requestForm);
            
        }
    }
}
