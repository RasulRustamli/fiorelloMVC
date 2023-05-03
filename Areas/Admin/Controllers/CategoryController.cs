using fiorelloMVC.DataContext;
using Microsoft.AspNetCore.Mvc;

namespace fiorelloMVC.Areas.Admin.Controllers;
[Area("Admin")]
public class CategoryController : Controller
{
    private readonly FiorellaDbContext _context;

    public CategoryController(FiorellaDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View(_context.Catagories.ToList());
    }
    public IActionResult Create()
    {
        return View();
    }
}
