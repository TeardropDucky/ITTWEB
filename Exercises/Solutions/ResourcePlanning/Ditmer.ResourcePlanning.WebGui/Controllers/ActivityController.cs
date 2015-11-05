using System.Web.Mvc;
using Ditmer.ResourcePlanning.Core.Commands.Requests;
using Ditmer.ResourcePlanning.Core.Queries.Requests;
using Ditmer.ResourcePlanning.Dto;
using MediatR;
using MvcContrib.Filters;
using MvcContrib;

namespace Ditmer.ResourcePlanning.WebGui.Controllers
{
    [ModelStateToTempData]
    public class ActivityController : Controller
    {
        private readonly IMediator _mediator;

        public ActivityController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public ViewResult Index()
        {
            var model = _mediator.Send(new GetAllActivitiesQuery());
            return View(model);
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public RedirectToRouteResult Create(Activity activity)
        {
            if (!ModelState.IsValid)
            {
                return this.RedirectToAction(c => c.Create());
            }

            var newActivityId = _mediator.Send(new CreateActivityCommand(activity));
            return this.RedirectToAction(c => c.Edit(newActivityId));
        }

        [HttpGet]
        public ViewResult Edit(int id)
        {
            var activity = _mediator.Send(new GetActivityQuery(id));
            return View(activity);
        }

        [HttpPost]
        public RedirectToRouteResult Edit(Activity activity)
        {
            if (ModelState.IsValid)
            {
                _mediator.Send(new EditActivityCommand(activity));
            }
            
            return this.RedirectToAction(c => c.Edit(activity.Id));
        }
    }
}