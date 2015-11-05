using AutoMapper;
using Ditmer.ResourcePlanning.Core.Models;

namespace Ditmer.ResourcePlanning.Core.Mapping
{
    public class ActivityMappingProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Activity, Dto.Activity>()
                .ForMember(dest => dest.Id, m => m.MapFrom(src => src.Id))
                .ForMember(dest => dest.Title, m => m.MapFrom(src => src.Title))
                ;
        }
    }
}