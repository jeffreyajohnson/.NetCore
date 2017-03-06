using Microsoft.AspNetCore.Http;  //Why is this included if not needed?  Need later?
using Microsoft.AspNetCore.Mvc;
namespace Hello.Controllers
{
    public class HelloController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
            //OR
           // return View("Index");
            //Both of these returns will render the same view (You only need one!)
        }
    }
}
