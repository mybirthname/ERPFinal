using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Common
{
    public class UserLoginData
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    public class UserAdminInputData
    {
        public Guid OrganizationID { get; set; }
        public string Email { get; set; }
    }
}
