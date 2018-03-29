using DDD.Application;
using System.Web.Mvc;

namespace DDD.UI.MVC.Controllers
{
    public class HomeController : Controller
    {
        private ISimpleService _simpleService;

        public HomeController(ISimpleService simpleService)
        {
            _simpleService = simpleService;
        }

        public string Index()
        {
            return _simpleService.GetSimple(1).Name;
        }
    }
}