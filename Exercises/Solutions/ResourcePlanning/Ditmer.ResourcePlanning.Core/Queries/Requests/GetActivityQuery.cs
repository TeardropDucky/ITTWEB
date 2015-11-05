using System;
using System.Collections.Generic;
using Ditmer.ResourcePlanning.Dto;
using MediatR;

namespace Ditmer.ResourcePlanning.Core.Queries.Requests
{
    public class GetActivityQuery : IRequest<Activity>
    {
        public int Id { get; set; }

        /// <summary>
        /// Constructor for GetActivityQuery
        /// </summary>
        /// <param name="id">The ID of the activity to get from storage</param>
        /// <exception cref="ArgumentNullException">If the parameter ID is less than or 0 a ArgumentException is thrown</exception>
        public GetActivityQuery(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException(nameof(id));
            }

            Id = id;
        }
    }
}