using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {
        //
        // GET: /Store/

        //public ActionResult Index()
        public String Index()
        {
            //return View();
            return "Hello from Store.Index()";
        }

        public String Browse(string genre)
        {
            //return View();
            string message = HttpUtility.HtmlEncode("Store.Browse, Genre = " + genre);
            return message;
        }

        public String Details(int id)
        {
            //return View();
            string message = HttpUtility.HtmlEncode("Store.Details, id = " + id);
            return message;
        }

    }
}
