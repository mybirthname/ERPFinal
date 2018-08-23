using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.RazorLibrary.Helpers.Messages
{
    [Serializable]
    public class MessageModel
    {
        public string Type { get; set; }

        public string Message { get; set; }
    }
}
