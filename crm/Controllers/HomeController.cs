using crm.DAL;
using crm.DAL.DTO;
using crm.ViewModel.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace crm.Controllers
{
    public class HomeController : Controller
    {
        private WebService webservice = new WebService();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult MyProfile()
        {
            ViewBag.Message = "My Profile page.";
            return View();
        }

        public JsonResult LoginHistoryAjaxHandler()
        {
            // Retrieve the model from DAL
            int userID = 0;
            List<LoginHistoryData> data = webservice.GetLoginHistory(userID);

            // Create view model
            List<LoginHistory> viewModel = new List<LoginHistory>();
            foreach (LoginHistoryData item in data)
            {
                LoginHistory info = new LoginHistory();
                info.Date = item.LoginDateTime;
                info.Time = item.LoginDateTime;
                info.IPAddress = item.IPAddress;
                info.Browser = item.Browser;
                info.Status = item.Status;
                viewModel.Add(info);
            }

            var result = new JsonResult
            {
                JsonRequestBehavior = JsonRequestBehavior.AllowGet,
                Data = new { draw = 1, recordsTotal = 12, recordsFiltered =12, data = viewModel }
            };

            return result;
        }

        [HttpPost]
        public void PostLoginHistory()
        {

        }
    }
}