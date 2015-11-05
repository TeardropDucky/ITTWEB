using System;
using System.Collections.Generic;
using Ditmer.ResourcePlanning.Dto;
using MediatR;

namespace Ditmer.ResourcePlanning.Core.Queries.Requests
{
    public class GetActivitiesForBudgetPeriodeQuery : IRequest<List<Activity>>
    {
        public int BudgetPeriodeId { get; set; }

        public GetActivitiesForBudgetPeriodeQuery(int budgetPeriodeId)
        {
            BudgetPeriodeId = budgetPeriodeId;
        }
    }
}