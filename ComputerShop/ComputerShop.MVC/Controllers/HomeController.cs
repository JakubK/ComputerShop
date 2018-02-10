using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComputerShop.MVC.Controllers
{
    public class HomeController : Controller
    {
        private IDoStuff Do;
        // GET: Home

        public HomeController()
        {

        }

        public HomeController(IDoStuff stuff)
        {
            this.Do = stuff;
        }

        public string Index()
        {
            return Do.Property;
        }
    }
}