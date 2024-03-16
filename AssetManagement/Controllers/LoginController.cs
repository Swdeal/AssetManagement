using Microsoft.AspNetCore.Mvc;

namespace AssetManagement.Controllers
{
    public class LoginController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
