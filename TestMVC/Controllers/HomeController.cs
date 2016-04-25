using ModelsAndRepository;
using ModelsAndRepository.Repositories;
using System;
using PagedList.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestMVC.Models;
using PagedList;

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
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Products(int? page)
        {
            int pageSize = 21;
            int pageNumber = (page ?? 1);
            IEnumerable<artikul> products = Repository.FindAll();
            ProductsViewModel viewModel = new ProductsViewModel();
            viewModel.Products = products.ToPagedList(pageNumber, pageSize);

            return View(viewModel);
        }
    }
}