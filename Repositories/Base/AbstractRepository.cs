using System.Data;
using DotNetExampleApi.Configuration;

namespace DotNetExampleApi.Repositories
{
    public abstract class AbstractRepository
    {
        protected readonly IMySqlDataSourceConfiguration MySqlDataSourceConfiguration;

        protected AbstractRepository(IMySqlDataSourceConfiguration MySqlDataSourceConfiguration)
        {
            this.MySqlDataSourceConfiguration = MySqlDataSourceConfiguration;
            // Dapper to ignore/remove underscores in field names mapping
            Dapper.DefaultTypeMap.MatchNamesWithUnderscores = true;
        }

        protected IDbConnection GetDbConnection()
        {
            return this.MySqlDataSourceConfiguration.GetDataSource();
        }
    }
}