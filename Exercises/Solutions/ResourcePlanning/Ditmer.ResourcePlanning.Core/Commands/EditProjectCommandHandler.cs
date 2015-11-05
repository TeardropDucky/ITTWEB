using System.Data.Entity;
using System.Linq;
using Ditmer.ResourcePlanning.Core.Commands.Requests;
using Ditmer.ResourcePlanning.Core.Models;
using MediatR;

namespace Ditmer.ResourcePlanning.Core.Commands
{
    public class EditActivityCommandHandler : IRequestHandler<CreateActivityCommand, int>
    {
        private readonly DbContext _context;

        public EditActivityCommandHandler(DbContext context)
        {
            _context = context;
        }

        public int Handle(CreateActivityCommand message)
        {
            var activity = _context.Set<Activity>()
                                   .Single(x => x.Id == message.Activity.Id);

            activity.Title = message.Activity.Title;
           
            _context.SaveChanges();

            return activity.Id;
        }
    }
}