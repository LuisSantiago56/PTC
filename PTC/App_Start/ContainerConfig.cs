using Autofac;
using Autofac.Integration.Mvc;
using PTCData.Services;
using System.Web.Mvc;

namespace PTC
{
    public class ContainerConfig
    {
        internal static void RegisterContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            //builder.RegisterApiControllers(typeof(MvcApplication).Assembly);

            builder.RegisterType<SqlTrainingProductsData>()
                .As<ITrainingProductsData>()
                .InstancePerRequest();
            //Now I dont want to be a Single Instance because DB context is not a safe thread class

            builder.RegisterType<PTCContext>().InstancePerRequest();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            //httpConfiguration.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}