using System.Data.Entity;
using Ditmer.ResourcePlanning.Core.Commands.Requests;
using Ditmer.ResourcePlanning.Core.Models;
using MediatR;

namespace Ditmer.ResourcePlanning.Core.Commands
{
    public class CreateActivityCommandHandler : IRequestHandler<CreateActivityCommand, int>
    {
        private readonly DbContext _context;

        public CreateActivityCommandHandler(DbContext context)
        {
            _context = context;
        }

        public int Handle(CreateActivityCommand message)
        {
            var activity = new Activity
            {
                Title = message.Activity.Title
            };

            _context.Set<Activity>().Add(activity);
            _context.SaveChanges();

            return activity.Id;
        }
    }
}