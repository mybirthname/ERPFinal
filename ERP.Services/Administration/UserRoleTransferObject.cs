using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Services.Administration
{
    public class UserRoleTransferObject
    {
        public string UserID { get; set; }
        public string Role { get; set; }

    }

    public class UserRoleResultObject
    {
        public bool HasAddRoleException { get; set; }
        public bool HasRemoveRoleException { get; set; }
        public string Message { get; set; }
        public string Role { get; set; }
    }

}
