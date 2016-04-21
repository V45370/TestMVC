using ModelsAndRepository;
using ModelsAndRepository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestMVC.Controllers
{
    public class HomeController : Controller
    {
        public ArtikulRepository Repository { get; set; }

        public HomeController()
        {
            Repository = new ArtikulRepository();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            string churka = "huiche";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult GetProducts()
        {
            IEnumerable<artikul> products = Repository.FindAll();

            return View(products);
        }
    }
}