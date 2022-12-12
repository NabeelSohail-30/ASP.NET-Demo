using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CsharpWebAppDemo.Database.Models
{
    public class LoginModel
    {
        public int LoginId;
        public string LoginEmail;
        public string UserFullName;
        public string LoginPassword;
        public int RoleId;
        public string LoginRole;
        public string RoleDescription;
        public bool IsActive;
        public bool AccountLocked;
        public DateTime CreationDateTime;
    }
}