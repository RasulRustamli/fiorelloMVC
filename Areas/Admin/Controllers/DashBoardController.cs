using Microsoft.AspNetCore.Mvc;

namespace fiorelloMVC.Areas.Admin.Controllers;
[Area("Admin")]
public class DashBoardController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
