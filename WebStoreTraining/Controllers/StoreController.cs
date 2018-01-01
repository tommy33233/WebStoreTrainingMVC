using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebStoreTraining.Models;

namespace WebStoreTraining.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            return View();
        }

        public string Browse(string category)
        {
            string message = HttpUtility.HtmlEncode("showing category " + category);
            return message;
        }

        public ActionResult Details(int id)
        {
            var item = new Items {Title = = "Item" + id};
            return View();
        }
    }
}