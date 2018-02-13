using Autofac;
using Autofac.Integration.WebApi;
using System.Reflection;
using System.Web.Http;
using FirstCentral.Business.Policy;
using FirstCentral.Data.FocusData;

namespace FirstCentral.Focus.App_Start
{
    /// <summary>
    /// Config for Autofac
    /// </summary>
    public class AutofacWebapiConfig
    {
        public static IContainer Container;

        public static void Initialize(HttpConfiguration config)
        {
            Initialize(config, RegisterServices(new ContainerBuilder()));
        }

        public static void Initialize(HttpConfiguration config, IContainer container)
        {
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }

        private static IContainer RegisterServices(ContainerBuilder builder)
        {
            //Register your Web API controllers.  
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            //Register types

            builder.RegisterType<Repository>()
                .As<IRepository>();

            builder.RegisterType<PolicyService>()
                   .As<IPolicyService>()
                   .InstancePerRequest();

            //Set the dependency resolver to be Autofac.  
            Container = builder.Build();

            return Container;
        }
    }
}