using System;
using Modist.Services;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Modist.Entities;

namespace Modist.Controllers
{
    public class CategoryController : Controller
    {

        CategoriesService sc = new CategoriesService();


        // GET: Category
        public ActionResult Index()
        {
            var ListOfCategory = sc.GetAllCategories();
            return View(ListOfCategory);
        }

        [HttpGet]
        public ActionResult Create ()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult Create(Category category)
        {
            sc.SaveCategory(category);

            return View();
        }
    }
}