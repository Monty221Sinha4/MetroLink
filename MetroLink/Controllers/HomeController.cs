using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MetroLink;
namespace MetroLink.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        private NewDBF1 dBF1= new NewDBF1();
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult TimeTable()
        {
            return View(dBF1.TrainTimeTables.ToList());
        }
    }
}