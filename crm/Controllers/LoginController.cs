using crm.ViewModel.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace crm.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Login model)
        {
            if (ModelState.IsValid) { }

            ViewData["LoginIdDoesnotExist"] = @Resources.Resources.LoginIdDoesnotExist;
            return View("Index");
        }
    }
}