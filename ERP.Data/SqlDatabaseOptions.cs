using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Data
{
    public class SqlDatabaseOptions: IDatabaseOptions
    {
        public string ConnectionString { get; set; }
    }
}
