using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers
{
    public class HelloWorldController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}
        //GET: /HelloWorld/
 
        //GET: /HelloWorld/Welcome/
        // Requires using System.Text.Encodings.Web;
        public string Welcome(string name, int numTimes = 1)

        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
