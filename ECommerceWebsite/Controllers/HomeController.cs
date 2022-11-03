using ECommerceWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECommerceWebsite.Controllers
{
    public class HomeController : Controller
    {
        EcommerceEntities2 db = new EcommerceEntities2();
        public ActionResult Index()
        {
            return View(db.ProductTables.OrderByDescending(x => x.prodid).ToList());
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

    }
}