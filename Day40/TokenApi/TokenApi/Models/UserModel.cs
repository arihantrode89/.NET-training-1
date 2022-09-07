using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TokenApi.Models
{
    public class UserModel
    {
        ForumSiteEntities db = new ForumSiteEntities();
        public UserManagement ValidateUser(string username,string password)
        {
            return db.UserManagements.FirstOrDefault(s => s.UserName == username && s.Password==password);
        }
    }
}