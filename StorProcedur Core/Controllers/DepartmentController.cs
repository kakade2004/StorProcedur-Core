using Microsoft.AspNetCore.Mvc;

namespace StorProcedur_Core.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
