using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoProgra6.Controllers
{
    public class PruebaController : Controller
    {
        // GET: Prueba
        public ActionResult Index()
        {
            return View();
        }

        [Httppost]
        public ActionResult Index()
        {
            return View();
        }
    }
}