using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Common
{
    [Serializable]
    public class UserSession
    {
        private Guid superProviderOrganizationID = new Guid("065548f8-a5a6-4e2a-a30f-000b8d109ed2");
        private bool _isSuperProvider;

        public string UserID { get; set; }

        public Guid OrganizationID { get; set; }

        public string UserFullName { get; set; }

        public bool IsSuperProvider
        {
            get
            {
                _isSuperProvider = false;
                if (superProviderOrganizationID == OrganizationID)
                    _isSuperProvider = true;

                return _isSuperProvider;
            }
            set { _isSuperProvider = value; }
        }
    }

}
