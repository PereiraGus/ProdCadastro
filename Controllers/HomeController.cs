using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Collections.ObjectModel;
using ProdCadastro.Models;

namespace ProdCadastro.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var prod = new Prod();
            return View(prod);
        }

        [HttpPost]

        public ActionResult Index(Prod prod)
        {
            if(ModelState.IsValid)
            {
                return View("Result", prod);
            }
            return View(prod);
        }

        public ActionResult Result(Prod prod)
        {
            return View(prod);
        }

        public ActionResult UniqueCod(int Codigo)
        {
            var dbExample = new Collection<int>
            {
                1,
                2,
                3
            };
            return Json(JsonRequestBehavior.AllowGet);
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