using MediaServiceLib.Models;
using MediaServiceLib.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PolyWave.Controllers
{
    public class HomeController : Controller
    {
        MediaService service = new MediaService();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Categories()
        {
            return View();
        }

        public ActionResult Category()
        {
            string cat = RouteData.Values["id"].ToString();
            MediaListModel model = service.GetMediaByCategory(cat);
            return View(model);
        }


        public ActionResult Type()
        {
            return View();
        }

        public ActionResult mediaType()
        {
            string type = RouteData.Values["id"].ToString();
            MediaListModel model = service.GetMediaByType(type);
            return View(model);
        }
    }
}