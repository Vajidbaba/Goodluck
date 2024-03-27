using Microsoft.AspNetCore.Mvc;

namespace App.Admin.Web.Areas.Admin.Controllers
{
    public class DevelopController : Controller
    {
        public IActionResult List()
        {
            return View();
        }
    }
}
