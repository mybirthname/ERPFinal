using Microsoft.EntityFrameworkCore;
using System;

namespace ERP.Data
{
    public class ERPContext:DbContext
    {
        public SqlDatabaseOptions SqlDbOptions { get; set; }

        public ERPContext(SqlDatabaseOptions options)
        {
            SqlDbOptions = options;
        }


        protected override void OnConfiguring(Microsoft.EntityFrameworkCore.DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(SqlDbOptions.ConnectionString);
            }

            base.OnConfiguring(optionsBuilder);
        }

    }
}
