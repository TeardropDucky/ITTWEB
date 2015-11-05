using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Ditmer.ResourcePlanning.Core.Models;
using Ditmer.ResourcePlanning.Core.Queries;
using Ditmer.ResourcePlanning.Core.Queries.Requests;
using MediatR;

namespace Ditmer.ResourcePlanning.WebGui.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMediator _mediator;

        public HomeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public ActionResult Index()
        {
            var model = _mediator.Send(new GetActivitiesForBudgetPeriodeQuery(1));
            
            return View(model);
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