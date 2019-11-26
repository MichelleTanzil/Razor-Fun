using Microsoft.AspNetCore.Mvc;
namespace razor_fun
{
    public class RazorFunController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}