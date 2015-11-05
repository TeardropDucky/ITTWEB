using System;
using Ditmer.ResourcePlanning.Dto;
using MediatR;

namespace Ditmer.ResourcePlanning.Core.Commands.Requests
{
    public class EditActivityCommand : IRequest<int>
    {
        public Activity Activity { get; set; }

        /// <summary>
        /// Constructor for EditActivityCommand 
        /// </summary>
        /// <param name="activity">The activity DTO to create</param>
        /// <exception cref="ArgumentNullException">If the parameter activity is null a ArgumentNullException is thrown</exception>
        public EditActivityCommand(Activity activity)
        {
            if (activity == null)
            {
                throw new ArgumentNullException(nameof(activity));
            }

            Activity = activity;
        }
    }
}