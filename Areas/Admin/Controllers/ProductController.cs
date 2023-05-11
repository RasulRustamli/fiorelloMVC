using fiorelloMVC.DataContext;
using fiorelloMVC.Modals;
using fiorelloMVC.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace fiorelloMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly FiorellaDbContext _dataContext;
        private readonly IWebHostEnvironment _environment;

        public ProductController(FiorellaDbContext dataContext, IWebHostEnvironment environment)
        {
            _dataContext = dataContext;
            _environment = environment;
        }

        // GET: ProductController
        public ActionResult Index()
        {
           List<Product> products= _dataContext.Products.Include(x=>x.Catagories).Include(p=>p.Images).ToList();
            List<GetProductsVM> getProductsVMs = new List<GetProductsVM>();
            foreach (var product in products)
            {
                getProductsVMs.Add(new GetProductsVM
                {
                    Id=product.Id,
                    Name = product.Name,
                    Description = product.Description,
                    ImgName = product.Images.FirstOrDefault().Name,
                    CatagoriesName=product.Catagories.Name
                    
                });
            }
           

            return View(getProductsVMs);
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
