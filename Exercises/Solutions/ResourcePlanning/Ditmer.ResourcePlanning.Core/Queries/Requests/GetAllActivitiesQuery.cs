using System.Collections.Generic;
using Ditmer.ResourcePlanning.Dto;
using MediatR;

namespace Ditmer.ResourcePlanning.Core.Queries.Requests
{
    public class GetAllActivitiesQuery : IRequest<List<Activity>>
    {
        public GetAllActivitiesQuery()
        {
        }
    }
}