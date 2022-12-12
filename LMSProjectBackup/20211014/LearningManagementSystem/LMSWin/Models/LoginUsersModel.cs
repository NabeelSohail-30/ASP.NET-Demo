using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSWin.Models
{
    class LoginUsersModel
    {
        public int LoginId { get; set; }
        public string LoginEmail { get; set; }
        public string LoginPassword { get; set; }
        public string UserFullName { get; set; }
        public int UserRoleId { get; set; }
        public RoleModel UserRole { get; set; }

        public DateTime LoggedDateTime { get; set; }

        //Relation LoginUsersModel <--> LoginUserRole
        //Each LoginUsersModel.LoginID will have only One Role from LoginUsersRole.Role
        //One to One Relation

    }
}
