using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComputerShop.MVC.Controllers
{
    public class DoStuff : IDoStuff
    {
        public string Property { get; set; }

        public DoStuff()
        {
            Property = "Bye";
        }
    }
}