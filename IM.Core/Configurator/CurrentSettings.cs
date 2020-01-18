using IM.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace IM.Core.Configurator
{
    public class CurrentSettings
    {
        public DatabaseSettings DatabaseSettings { get; set; }
        public MongoDBSettings MongoDBSettings { get; set; }
    }

    public class DatabaseSettings
    {
        public CurrentDatabase CurrentDatabase { get; set; }
    }

    public class MongoDBSettings
    {
        public string ConnectionString { get; set; }
        public string Database { get; set; }
    }
}
