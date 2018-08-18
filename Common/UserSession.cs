using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Common
{
    [Serializable]
    public class UserSession
    {
        public string UserID { get; set; }

        public int OrganizationID { get; set; }
    }

}
