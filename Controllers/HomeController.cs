using kendoTest.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Project1.Controllers
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

        // Add this action method to handle the form submission
        [HttpPost]
        public IActionResult SubmitForm(Form404Model formData)
        {
            // Process the form data here
            // Example: Log the received data
            _logger.LogInformation($"Mantralaya: {formData.Mantralaya}, Karlaya: {formData.Karlaya}");

            // Return a response if needed
            return Json(new { success = true });
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}