﻿using MediaServiceLib.Models;
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
        IMediaService service = new MediaService();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Categories()
        {
            return View();
        }

        public ActionResult Category(MediaModel category)
        {
            MediaListModel model = service.GetMediaByCategory(category);
            return View(model);
        }


        public ActionResult Type()
        {
            return View();
        }
        public ActionResult mediaType(MediaModel type)
        {
            MediaListModel model = service.GetMediaByType(type);
            return View(model);
        }
    }
}