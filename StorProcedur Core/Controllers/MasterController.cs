using Microsoft.AspNetCore.Mvc;

namespace StorProcedur_Core.Controllers
{
    public class MasterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult show()
        {
            return View();
        }
    }
}
