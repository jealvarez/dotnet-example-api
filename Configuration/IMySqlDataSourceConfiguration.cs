using System.Data;

namespace DotNetExampleApi.Configuration
{
    public interface IMySqlDataSourceConfiguration
    {
        IDbConnection GetDataSource();
    }
}