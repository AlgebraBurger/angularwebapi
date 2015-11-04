using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngularJs.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public JsonResult Todo()
        {
            var todoList = new List<Todo>
            {
                new Todo { action="Go Biking" , done= true },
                new Todo { action="Go Swimming" , done= true },
                new Todo { action="Go Eating" , done= true },
                new Todo { action="Go Cooking" , done= true },

            };
            return Json(todoList,JsonRequestBehavior.AllowGet);

            
        }
    }
}
