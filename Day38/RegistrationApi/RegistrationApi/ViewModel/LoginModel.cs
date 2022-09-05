﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegistrationApi.ViewModel
{
    public class LoginModel
    {
        [Required(ErrorMessage ="UserName is Required")]
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}