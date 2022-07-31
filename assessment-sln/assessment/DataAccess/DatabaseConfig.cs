using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace assessment.DataAccess
{
    public class DatabaseConfig : IDatabaseConfig
    {
        public string ConnectionString { get; set; }
    }
}