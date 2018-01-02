using System.Collections.Generic;
using System.Web.Mvc;
using WebStoreTraining.Models;

namespace WebStoreTraining.Controllers
{
    public class StoreController : Controller
    {
        public ActionResult Index()
        {
            var category = new List<Category>
            {
                new Category {Name = "Electronics"},
                new Category {Name = "Furniture"},
                new Category {Name = "Accessories"}
            };
            return View(category);
        }

        public ActionResult Browse(string category)
        {
            var categoryModel = new Category {Name = category};
            return View(categoryModel);
        }

        public ActionResult Details(int id)
        {
            var item = new Items {Title = "Item" + id};
            return View();
        }
    }
}