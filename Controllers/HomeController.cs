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
        List<Catagory> catagories = await _dbContext.Catagories.Include(c=>c.Products).ToListAsync();
        List<Product> products = await _dbContext.Products.Include(p=>p.Catagories).ToListAsync();

        HomeVM homeVM = new HomeVM()
        {
            Products = products,
            Catagories = catagories
        };
        return View(homeVM);
    }


    public IActionResult ProductDetail()
    {
        Product product = _dbContext.Products.Include(x=>x.Tags).Include(x=>x.Catagories).FirstOrDefault();
        return View(product);
    }

}
