using MVC_22_Partial_View_3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_22_Partial_View_3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult _UrunDondur()
        {
            NORTHWND db = new NORTHWND();
            List<Product> ilkOnUrun = db.Products.Take(10).ToList();
            return PartialView(ilkOnUrun);
        }

        public ActionResult DenemeSayfasi()
        {
            return View();
        }
    }
}