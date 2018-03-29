using DDD.Application;
using DDD.Domain.Model;
using DDD.Infrastructure.IoC;
using Repository;
using System.Web.Mvc;
using System.Web.Routing;

namespace DDD.UI.MVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            IIoCContainer container = new StructureMapContainer();
            //IIoCContainer container = new AutofacContainer();
            //IIoCContainer container = Activator.CreateInstance(
            //    Type.GetType("DDD.Infrastructure.IoC.StructureMapContainer,DDD.Infrastructure")
            //    ) as IIoCContainer;

            container.Add<ISimpleRepository, SimpleRepository>();
            container.Add<ISimpleService, SimpleService>();
            IoCEngine.Init(container);
            ControllerBuilder.Current.SetControllerFactory(new IoCControllerFactory());
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}