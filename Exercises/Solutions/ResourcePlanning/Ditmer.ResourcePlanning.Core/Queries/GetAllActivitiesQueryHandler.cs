using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using AutoMapper.QueryableExtensions;
using Ditmer.ResourcePlanning.Core.Models;
using Ditmer.ResourcePlanning.Core.Queries.Requests;
using MediatR;

namespace Ditmer.ResourcePlanning.Core.Queries
{
    public class GetAllActivitiesQueryHandler : IRequestHandler<GetAllActivitiesQuery, List<Dto.Activity>>
    {
        private readonly DbContext _context;

        public GetAllActivitiesQueryHandler(DbContext context)
        {
            _context = context;
        }

        public List<Dto.Activity> Handle(GetAllActivitiesQuery message)
        {
            var model = _context.Set<Activity>()
                                .AsNoTracking()
                                .ProjectTo<Dto.Activity>()
                                .ToList()
                                ;
            return model;
        }
    }
}