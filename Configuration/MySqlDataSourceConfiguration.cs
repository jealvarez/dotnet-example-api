using System.Data;
using DotNetExampleApi.Models.Configuration;
using Microsoft.Extensions.Options;
using MySql.Data.MySqlClient;

namespace DotNetExampleApi.Configuration
{
    public class MySqlDataSourceConfiguration : IMySqlDataSourceConfiguration
    {
        private readonly IOptions<MySqlDataSourcePropertyConfiguration> MySqlDataSourcePropertyConfigurationOptions;

        public MySqlDataSourceConfiguration(IOptions<MySqlDataSourcePropertyConfiguration> MySqlDataSourcePropertyConfigurationOptions)
        {
            this.MySqlDataSourcePropertyConfigurationOptions = MySqlDataSourcePropertyConfigurationOptions;
        }

        public IDbConnection GetDataSource()
        {
            var MySqlDataSourcePropertyConfiguration = this.MySqlDataSourcePropertyConfigurationOptions.Value;
            var ConnectionString = @"Server=" + MySqlDataSourcePropertyConfiguration.Host
                                    + ";Port=" + MySqlDataSourcePropertyConfiguration.Port
                                    + ";Database=" + MySqlDataSourcePropertyConfiguration.Database
                                    + ";Uid=" + MySqlDataSourcePropertyConfiguration.User
                                    + ";Pwd=" + MySqlDataSourcePropertyConfiguration.Password
                                    + ";SslMode=None;";

            return new MySqlConnection(ConnectionString);
        }
    }
}