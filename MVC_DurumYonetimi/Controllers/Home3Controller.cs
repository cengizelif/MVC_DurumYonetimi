using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace MVC_DurumYonetimi.Controllers
{
    public class Home3Controller : Controller
    {
        // GET: Home3
        public ActionResult Index()
        {
            HttpContext.Cache.Add("ad", "Elif", null, System.Web.Caching.Cache.NoAbsoluteExpiration, new TimeSpan(0, 0, 10), System.Web.Caching.CacheItemPriority.Normal, CacheSilindiginde);
            //HttpContext.Cache.Add("ad", "Elif", null,new DateTime(2023,04,12,10,10,10), System.Web.Caching.Cache.NoSlidingExpiration, System.Web.Caching.CacheItemPriority.Normal,);
     
            return View();                   
        
        }

        private void CacheSilindiginde(string key,object deger,System.Web.Caching.CacheItemRemovedReason reason)
        {
            System.IO.File.WriteAllText(Server.MapPath("~/cahcesilindi.txt"), $"{key} cache değeri:{deger.ToString()} silindi.Sebep:{reason.ToString()}");
        }

        public ActionResult Index2()
        {
            return View();
        }

        public ActionResult Index3()
        {
            HttpContext.Cache.Remove("ad");
            return View();
        }
    }
}