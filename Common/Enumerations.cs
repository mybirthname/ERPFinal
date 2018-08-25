using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Common
{
    public class Enumerations
    {

        public enum OrderStatus : int
        {
            NotUserd = 0,

            InProcess = 5,

            Sent = 30,

            Confirm = 60,

            Rejected = 80
        }


    }
}
