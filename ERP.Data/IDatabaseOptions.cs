using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Data
{
    interface IDatabaseOptions
    {
        string ConnectionString { get; set; }
    }
}
