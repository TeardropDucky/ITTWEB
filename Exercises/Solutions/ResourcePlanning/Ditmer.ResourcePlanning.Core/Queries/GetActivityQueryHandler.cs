using System.Data.Entity;
using System.Linq;
using AutoMapper;
using Ditmer.ResourcePlanning.Core.Models;
using Ditmer.ResourcePlanning.Core.Queries.Requests;
using MediatR;

namespace Ditmer.ResourcePlanning.Core.Queries
{
    public class GetActivityQueryHandler : IRequestHandler<GetActivityQuery, Dto.Activity>
    {
        private readonly DbContext _context;
        private readonly IMappingEngine _mappingEngine;

        public GetActivityQueryHandler(DbContext context, IMappingEngine mappingEngine)
        {
            _context = context;
            _mappingEngine = mappingEngine;
        }

        public Dto.Activity Handle(GetActivityQuery message)
        {
            var model = _context.Set<Activity>()
                                .AsNoTracking()
                                .Single(x=>x.Id == message.Id)
                                ;

            var activity = _mappingEngine.Map<Dto.Activity>(model);
            return activity;
        }
    }
}