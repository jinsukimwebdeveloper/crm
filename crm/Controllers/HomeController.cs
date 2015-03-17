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

        public JsonResult GetLoginHistory()
        {
            // Retrieve the model from DAL
            int userID = 0;
            List<LoginHistoryModel> loginHistoryData = webservice.GetLoginHistory(userID);
            List<LoginHistoryViewModel> result = new List<LoginHistoryViewModel>();
            foreach (LoginHistoryModel model in loginHistoryData)
            {
                LoginHistoryViewModel viewModel = new LoginHistoryViewModel();
                viewModel.Date = model.LoginDateTime;
                viewModel.Time = model.LoginDateTime;
                viewModel.Browser = model.Browser;
                viewModel.IPAddress = model.IPAddress;
                viewModel.Status = model.Status;
                result.Add(viewModel);
            }

            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public void PostLoginHistory()
        {

        }
    }
}