using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController: Controller
    {
          public IActionResult Index()
        {
            return View();
        }

        // 
      // GET: /HelloWorld/Welcome/ 
// Requires using System.Text.Encodings.Web;
        public IActionResult Welcome(string name, int numTimes = 1)
        {
           ViewData["Message"]= "hello"+ name;
           ViewData["NumTImes"] = numTimes;
           return View();
        }
    }
}