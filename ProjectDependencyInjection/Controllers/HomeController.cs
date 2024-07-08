using ProjectDI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectDI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMyService _myService;
        public HomeController(IMyService myService)
        {
            _myService = myService;
        }
        public ActionResult Index()
        {
            var message = _myService.GetMessage();
            ViewBag.Message = message;
           // var container = Containerconfiguration.configure();
            //using (var scope = container.BeginLifetimeScope())
            //{
            //    IPerson person = scope.Resolve<IPerson>();

            //    person.Study(scope.Resolve<ISchool>());
            //    person.TakeTretment(scope.Resolve<IHospital>());
            //}
            return View();
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}