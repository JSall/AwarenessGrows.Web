using System.Web.Mvc;
using AwarenessGrows.Web.Helpers;

namespace AwarenessGrows.Web.Controllers
{
    public class BaseController : Controller
    {
        //protected virtual new CustomClaimsPrincipal User
        //{
        //    get { return HttpContext.User as CustomClaimsPrincipal; }
        //}
        public void Warning(string message)
        {
            if (TempData.ContainsKey(WebConstants.Alerts.WARNING))
            {
                var temp = TempData[WebConstants.Alerts.WARNING].ToString();
                TempData.Remove(WebConstants.Alerts.WARNING);
                TempData.Add(WebConstants.Alerts.WARNING, temp + " <br /> " + message);
            }
            else
            {
                TempData.Add(WebConstants.Alerts.WARNING, message);
            }
        }

        public void Success(string message)
        {
            if (TempData.ContainsKey(WebConstants.Alerts.SUCCESS))
            {
                var temp = TempData[WebConstants.Alerts.SUCCESS].ToString();
                TempData.Remove(WebConstants.Alerts.SUCCESS);
                TempData.Add(WebConstants.Alerts.SUCCESS, temp + " <br /> " + message);
            }
            else
            {
                TempData.Add(WebConstants.Alerts.SUCCESS, message);
            }
        }

        public void Information(string message)
        {
            if (TempData.ContainsKey(WebConstants.Alerts.INFORMATION))
            {
                var temp = TempData[WebConstants.Alerts.INFORMATION].ToString();
                TempData.Remove(WebConstants.Alerts.INFORMATION);
                TempData.Add(WebConstants.Alerts.INFORMATION, temp + " <br /> " + message);
            }
            else
            {
                TempData.Add(WebConstants.Alerts.INFORMATION, message);
            }
        }

        public void Error(string message)
        {
            if (TempData.ContainsKey(WebConstants.Alerts.ERROR))
            {
                var temp = TempData[WebConstants.Alerts.ERROR].ToString();
                TempData.Remove(WebConstants.Alerts.ERROR);
                TempData.Add(WebConstants.Alerts.ERROR, temp + " <br /> " + message);
            }
            else
            {
                TempData.Add(WebConstants.Alerts.ERROR, message);
            }
        }

    }
}