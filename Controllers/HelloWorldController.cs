using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVCMovie.Controllers
{
    public class HelloWorldController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public string Welcome(string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, number of times is: {numTimes}");
        }
    }
}