using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_DurumYonetimi.Controllers
{
    public class Home4Controller : Controller
    {
        // GET: Home4
        public ActionResult Index()
        {
            HttpCookie cookie = new HttpCookie("username", "elifcengiz");
            //cookie.Expires = DateTime.Now.AddSeconds(10); ;
            HttpContext.Response.Cookies.Add(cookie);   

            return View();
        }

        public ActionResult Index2() 
        {
            if(HttpContext.Request.Cookies["username"]!=null)
            { 
               ViewBag.username = HttpContext.Request.Cookies["username"].Value;
            }
            else
            {
                ViewBag.username = "Cookie bulunamadı";
            }         

            return View();  
        }

        public ActionResult Index3() 
        {
            if (HttpContext.Request.Cookies["username"] != null)
            {
                //HttpContext.Request.Cookies.Remove("username");
                HttpContext.Response.Cookies["username"].Expires = DateTime.Now.AddSeconds(2);
            }

                return View();    
        }
    }
}