using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace crm.ViewModel.Home
{
    public class MyProfileViewModel
    {
        // Contact
        public string Name { get; set; }
        public string Title { get; set; }
        public string Dept { get; set; }
        public string Org { get; set; }
        public string Manager { get; set; }
        public string Email { get; set; }
        public string office { get; set; }
        public string Mobile { get; set; }

        // Login history
        public List<LoginHistoryViewModel> LoginHistoryViewModel;

        public MyProfileViewModel()
        {
            LoginHistoryViewModel = new List<LoginHistoryViewModel>();
        }
    }

    public class LoginHistoryViewModel
    {
        public string Date { get; set; }
        public string Time { get; set; }
        public string IPAddress { get; set; }
        public string Browser { get; set; }
        public string Status { get; set; }
    }
}