using DDD.Infrastructure.IoC;
using System;
using System.Web.Mvc;
using System.Web.Routing;

namespace DDD.UI.MVC
{
    public class IoCControllerFactory : DefaultControllerFactory
    {
        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return IoCEngine.Container.GetInstance(controllerType) as IController;
        }
    }
}