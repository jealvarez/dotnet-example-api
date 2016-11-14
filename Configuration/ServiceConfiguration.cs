using Autofac;
using DotNetExampleApi.Services;

namespace DotNetExampleApi.Configuration
{
    public class ServiceConfiguration
    {
        public static ContainerBuilder AddServices(ContainerBuilder ContainerBuilder)
        {
            ContainerBuilder.RegisterType<AuthorityGroupService>().As<IAuthorityGroupService>();
            ContainerBuilder.RegisterType<MySqlDataSourceConfiguration>().As<IMySqlDataSourceConfiguration>();
            return ContainerBuilder;
        }
    }
}