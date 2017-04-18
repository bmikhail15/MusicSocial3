using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MusicSocial3._0.Models;

namespace MusicSocial3._0.Controllers
{
    public class MusicStoreController : Controller
    {
        // GET: MusicStore
        public ActionResult  Index()
        {
            return View();
        }

        public ActionResult Details(int id)
        {
            var album = new Album { Title = "Album" + id };
            return View(album);
        }
    }
}