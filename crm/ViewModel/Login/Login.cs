using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace crm.ViewModel.Login
{
    public class Login
    {
        [EmailAddress(ErrorMessageResourceName = "PleaseEnterValidEmailAddress", ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessage = null)]
        [Required(ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "PleaseEnterEmailAddress")] 
        public string EmailAddress { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessageResourceType = typeof(Resources.Resources), ErrorMessageResourceName = "PleaseEnterPassword")] 
        public string Password { get; set; }
    }
}