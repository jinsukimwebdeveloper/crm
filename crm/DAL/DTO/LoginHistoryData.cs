using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace crm.DAL.DTO
{
    public class LoginHistoryModel
    {
        public string LoginDateTime { get; set; }
        public string IPAddress { get; set; }
        public string Browser { get; set; }
        public string Status { get; set; }
    }
}