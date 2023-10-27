using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication5.Models;
using Microsoft.EntityFrameworkCore;


namespace WebApplication5.Controllers;

public class HomeController : Controller
{
    ApplicationContext Db;

    public HomeController(ApplicationContext context)
    {
        

        {
            Db = context;




            if (!Db.Shops.Any())
            {
                shop shop1 = new shop
                {
                    Name = "uplay", Price = 1, Keys = "123abc"
                };
                Db.Shops.AddRange(shop1);
                Db.SaveChanges();
            }


        }
    }

    public IActionResult AddKey()
    {
        var shop = Db.Shops.ToList();
        return View();
    }
    [HttpPost]
    public Task <IActionResult> AddKey(shop shop)
    {
        Db.AddRange(shop);
        Db.SaveChanges();
        return Task.FromResult<IActionResult>(RedirectToAction("addkey"));
    }

    public IActionResult Index()
        {
            var shops = Db.Shops.ToList();
            return View(shops);

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

