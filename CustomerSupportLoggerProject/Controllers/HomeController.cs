
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;

namespace CustomerSupportLoggerProject.Controllers
{
    public class HomeController : Controller
    {
        UserOperations user = null;
        public HomeController()
        {
            user = new UserOperations();
        }
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(FormCollection collection)
        {
            bool valid = user.ValidateUser(Request["Username"], Request["password"]);
            if (valid)
            {
                return RedirectToAction("Logger");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
        public ActionResult Logger()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Logger(FormCollection collection)
        {
            CustLogInfoTable4 c = new CustLogInfoTable4();
            c.Logid = Int32.Parse(Request["LogId"]);
            c.CustEmail = Request["CustEmail"];
            c.CustName = Request["CustName"];
            c.LogStatus = Request["LogStatus"];
            c.Userid = Int32.Parse(Request["UserId"]);
            c.Description = Request["Description"];
            user.Insert(c);
            return RedirectToAction("Index");
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