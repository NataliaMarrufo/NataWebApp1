using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NataWebApp1.Models
{
    public class UserAndRoleModel
    {
        public List<UserViewModel> Users { get; set; }
        public List<UserViewModel> Admins { get; set; }
        public List<UserViewModel> Manager { get; set; }

    }
    public class UserViewModel
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string RoleName { get; set; }
        public string Id { get; set; }
    }

}