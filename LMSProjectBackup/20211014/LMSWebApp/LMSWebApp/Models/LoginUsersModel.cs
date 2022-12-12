﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LMSWebApp.Models
{
    public class LoginUsersModel
    {
        public int LoginId { get; set; }
        public string LoginEmail { get; set; }
        public string LoginPassword { get; set; }
        public string UserFullName { get; set; }
        public int UserRoleId { get; set; }
        public DateTime LoggedDateTime { get; set; }
    }
}