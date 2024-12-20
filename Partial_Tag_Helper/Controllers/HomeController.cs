using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Partial_Tag_Helper.Models;

namespace Partial_Tag_Helper.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        var products = new List<Product> {
            new Product { Id = 1, Name = "Laptop", Description = "A powerful laptop for professionals Developere", Price = 999.99M, ImageUrl = "https://dummyimage.com/600x400/000/fff&text=Laptop", Category = "Electronics", InStock = true },
            new Product { Id = 2, Name = "Smartphone", Description = "Latest smartphone with cutting-edge features", Price = 799.99M, ImageUrl = "https://dummyimage.com/600x400/000/fff&text=Smartphone", Category = "Electronics", InStock = true },
            new Product { Id = 3, Name = "Headphones", Description = "Noise-cancelling over-ear headphones good for health", Price = 199.99M, ImageUrl = "https://dummyimage.com/600x400/000/fff&text=Headphones", Category = "Accessories", InStock = false }
        };
        return View(products);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
