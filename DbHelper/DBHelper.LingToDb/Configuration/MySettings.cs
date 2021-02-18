using LinqToDB.Configuration;
using System.Collections.Generic;
using System.Linq;

namespace DBHelper.LingToDb.Configuration
{
    public class MySettings : ILinqToDBSettings
    {
        public IEnumerable<IDataProviderSettings> DataProviders => Enumerable.Empty<IDataProviderSettings>();

        public string DefaultConfiguration => "SqlServer";
        public string DefaultDataProvider => "SqlServer";

        public IEnumerable<IConnectionStringSettings> ConnectionStrings
        {
            get
            {
                yield return
                    new ConnectionStringSettings
                    {
                        Name = "Invoice",
                        ProviderName = "SqlServer",
                        ConnectionString = @"Data Source=.;Initial Catalog=Invoice;Integrated Security=True"
                    };
            }
        }
    }
}
