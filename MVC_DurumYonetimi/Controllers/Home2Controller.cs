using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_DurumYonetimi.Controllers
{
    public class Home2Controller : Controller
    {
        // GET: Home2
        public ActionResult Index()
        {
            HttpContext.Application["sayac"] = 1;
           // HttpContext.Application.Add("sayac",1);

            return View();
        }

        public ActionResult Index2()
        {
            if (HttpContext.Application["sayac"]!=null)
            {
               ViewBag.sayac = HttpContext.Application["sayac"];
            }
            else
            {
                ViewBag.sayac = 0;
            }
            
            return View();
        }

        public ActionResult Index3() 
        {
            if (HttpContext.Application["sayac"] != null)
            {
               int sayac = (int)HttpContext.Application["sayac"];
                sayac++;
                HttpContext.Application["sayac"] = sayac;
            }
            else
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index2");
        }

        public ActionResult Index4()
        {
            //HttpContext.Application.Clear();
            //HttpContext.Application.RemoveAll();

            if (HttpContext.Application["sayac"] != null)
            {
                HttpContext.Application.Remove("sayac");
            }
            return RedirectToAction("Index2");
        }
    }
}