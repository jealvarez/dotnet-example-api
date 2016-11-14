using Autofac;
using DotNetExampleApi.Repositories;

namespace DotNetExampleApi.Configuration
{
    public class RepositoryConfiguration
    {
        public static ContainerBuilder AddRepositories(ContainerBuilder ContainerBuilder)
        {
            // Register dependencies, populate the services from
            // the collection, and build the container. If you want
            // to dispose of the container at the end of the app,
            // be sure to keep a reference to it as a property or field.
            ContainerBuilder.RegisterType<AuthorityGroupRepository>().As<IAuthorityGroupRepository>();
            return ContainerBuilder;
        }
    }
}