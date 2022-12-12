using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS
{
    class RoleModel
    {
        public int RoleId { get; set; }
        public string Role { get; set; }
        public string RoleDescription { get; set; }
        public int UserCreatedById { get; set; }
        public DateTime CreationDateTime { get; set; }
        public int UserLastUpdatedById { get; set; }
        public DateTime LastUpdatedDateTime { get; set; }

        //Relation LoginUserRole <--> LoginUsersModel
        //Each LoginUserRole.RoleId will have multiple from LoginUsersModel.LoginId
        //One to Many Relation
    }
}
