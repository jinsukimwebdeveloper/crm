using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace crm.ViewModel.Home
{
    public class LoginHistory
    {
        public string Date { get; set; }
        public string Time { get; set; }
        public string IPAddress { get; set; }
        public string Browser { get; set; }
        public string Status { get; set; }
    }
}