using ComputerShop.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComputerShop.MVC.Controllers
{
    public class HomeController : Controller
    {
        private IRepository repository;

        public HomeController(IRepository repo)
        {
            this.repository = repo;
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}