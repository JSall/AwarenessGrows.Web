using AwarenessGrows.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AwarenessGrows.Web.Controllers
{
    public class TakeActionController : BaseController
    {
        // GET: TakeAction
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult WriteSenator()
        {
            ContactInfoViewModel model = new ContactInfoViewModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult WriteSenator(ContactInfoViewModel model)
        {
            if (model.State.Length != 2 || String.IsNullOrWhiteSpace(model.State))
                return RedirectToAction("Index");

            return Redirect("http://www.senate.gov/general/contact_information/senators_cfm.cfm?State=" + model.State.ToUpper());
            
        }

        public ActionResult WriteHouseRep()
        {
            ContactInfoViewModel model = new ContactInfoViewModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult WriteHouseRep(ContactInfoViewModel model)
        {
            if (model.ZipCode.Length != 5 || String.IsNullOrWhiteSpace(model.ZipCode))
                return RedirectToAction("Index");


            return Redirect("http://ziplook.house.gov/htbin/findrep?ZIP=" + model.ZipCode+"&Submit=FIND+YOUR+REP+BY+ZIP");
        }
    }
}