using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860


namespace MyAspNetCoreApp.Web.Controllers
{
    public class Product2
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
   
    public class OrnekController : Controller
    {
      
        public IActionResult Index()
        {

            var productList = new List<Product2>()
            {
                new(){ Id=1, Name="Kalem" },
                new(){ Id=2, Name="Defter" },
                new(){ Id=3, Name="Silgi" }

            };

           // ViewBag.name = "selin";
            //TempData["surname"] = "can";

            return View(productList);

           /* ViewBag.name = "Asp.net.core";
            ViewData["age"] = 30;
            ViewData["names"]= new List<string>() { "selime", "selin", "can" };

            ViewBag.person = new { Id = 1, Name = "selin", Age = 20 };*/

            //ViewBag.name = new List<string>() { "selime","selin", "can" };
            return View();
        }


        public IActionResult Index2()
        {
            var surName = TempData["surname"];
            return View();
        }



        public IActionResult Index3()
        {
            //return View();
            return RedirectToAction("Index", "Ornek");  //başka sayfaya yönlendirme
            //veritabanı kaydetme işlemi 
        }

        public IActionResult ParametreView(int id)
        {
            return RedirectToAction("JsonResultParametre", "Ornek", new { id = id });
        }

        public IActionResult JsonResultParametre(int id)
        {
            return Json(new { Id = id });
        }

        public IActionResult ContentResult()
        {
            return Content("ContentResult");
        }

        public IActionResult JsonResult()
        {
            return Json(new { Id = 1, name = "kalem 1", price = 100 });
        }

        public IActionResult EmptyResult()
        {
            return new EmptyResult();
        }


    }
}

