using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_DurumYonetimi.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string text1)
        {
            Session["deger"] = text1;
            Session.Add("veri", text1);

            return RedirectToAction("Index2");
        }

        public ActionResult Index2() 
        {
            if(Session["deger"]!=null)
            {
               ViewBag.text = Session["deger"].ToString();
            }
            else
            {
                ViewBag.text = "Session verisi yok";
            }
            
            return View();
        }

        public ActionResult Index3() 
        {
           // Session.Clear();

            if(Session["deger"]!=null)
            {
                Session.Remove("deger");
            }

            return View();
        }
    }
}