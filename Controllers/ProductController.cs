using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using skbba_eservice.Models;

namespace skbba_eservice.Controllers
{
  public class ProductController : Controller
  {

    ILogger<ProductController> _logger;

    public ProductController(ILogger<ProductController> logger)
    {
      _logger = logger;
    }

    public IActionResult Index()
    {   
      return View();
    }

    public IActionResult ViewProduct()
    {
        /*
        Product _data = new Product();
        _data.Name = "book";
        _data.Detial = "ASP.Net CORE Mvc";
        _data.Price = 150.25M;
        */


        IEnumerable<Product> _data = new List <Product>{
            new Product()
            {
                Name = "book",
                Detial = "ASP.NET",
                Price = 150.25M   
            },
            new Product()
            {
                Name = "note",
                Detial = "ASP.NET MVC",
                Price = 500000000   
            }
            
        };

        return View(_data);
    }



  }
}