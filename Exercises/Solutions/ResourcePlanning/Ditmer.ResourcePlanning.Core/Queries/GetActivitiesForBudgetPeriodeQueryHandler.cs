using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using AutoMapper.QueryableExtensions;
using Ditmer.ResourcePlanning.Core.Models;
using Ditmer.ResourcePlanning.Core.Queries.Requests;
using MediatR;

namespace Ditmer.ResourcePlanning.Core.Queries
{
    public class GetActivitiesForBudgetPeriodeQueryHandler : IRequestHandler<GetActivitiesForBudgetPeriodeQuery, List<Dto.Activity>>
    {
        private readonly DbContext _context;

        public GetActivitiesForBudgetPeriodeQueryHandler(DbContext context)
        {
            _context = context;
        }

        public List<Dto.Activity> Handle(GetActivitiesForBudgetPeriodeQuery message)
        {
            var model = _context.Set<BudgetPeriode>()
                                .Where(x => x.Id == message.BudgetPeriodeId)
                                .SelectMany(x=>x.BudgetHoursOnActivities.Select(bh => bh.Activity))
                                .AsNoTracking()
                                .ProjectTo<Dto.Activity>()
                                .ToList()
                                ;
            return model;
        }
    }
}