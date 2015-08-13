using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AwarenessGrows.Web.Models;

namespace AwarenessGrows.Web.Controllers
{
    public class LibraryController : BaseController
    {
        // GET: Libray
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MMLibrary()
        {
            var model = MODELINITS.GETMMENTRIES();
            return View(model);
        }

        public ActionResult ReadMMEntry(int Id)
        {
            var model = MODELINITS.FINDMMENTRY(Id);
            return View(model);
        }

        public ActionResult TextLibrary()
        {
            var model = MODELINITS.GETTEXTENTRIES();
            return View(model);
        }

        public ActionResult ReadTextEntry(int Id)
        {
            var model = MODELINITS.FINDTEXTENTRY(Id);
            return View(model);
        }
    }
}