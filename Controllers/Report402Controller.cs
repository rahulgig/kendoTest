using kendoTest.Models;
using Microsoft.AspNetCore.Mvc;

namespace kendoTest.Controllers
{
    public class Report402Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet] 
        public IActionResult Form()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Form([FromBody]Report402ViewModel model)
        {
            Console.WriteLine(model);
            return Ok();
        }
    }
}
