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
            
            // Retrieve the data from DAL
            List<LoginHistoryData> data = webservice.GetLoginHistory("userID");
            
            // Create model
            MyProfileViewModel model = new MyProfileViewModel();
            foreach (LoginHistoryData item in data)
            {
                LoginHistoryViewModel info = new LoginHistoryViewModel();
                info.Date = item.LoginDateTime;
                info.Time = item.LoginDateTime;
                info.IPAddress = item.IPAddress;
                info.Browser = item.Browser;
                info.Status = item.Status;
                model.LoginHistoryViewModel.Add(info);
            }

            return View(model);
        }
    }
}