using fiorelloMVC.DataContext;
using fiorelloMVC.Modals;
using fiorelloMVC.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace fiorelloMVC.Controllers;

public class HomeController : Controller
{
    private readonly FiorellaDbContext _dbContext;
    public HomeController(FiorellaDbContext fiorellaDbContext)
    { 
        _dbContext = fiorellaDbContext;
    }
    public async Task<IActionResult> Index()
    { 
        
        var catagory=_dbContext.Catagories.Include(c=>c.Products).ThenInclude(c=>c.Tags).ToList();
       
        return View();
    }


    public IActionResult ProductDetail()
    {
        Product product = _dbContext.Products.Include(x=>x.Tags).Include(x=>x.Catagories).FirstOrDefault();
        return View(product);
    }

}
