using AutoMapper;
using PlatformService.Dtos;
using PlatformService.Models;

namespace PlatformService.Profiles
{
    public class PlatformProfile : Profile
    {
        public PlatformProfile()
        {
            CreateMap<Platform, PlatformReadDtos>();
            CreateMap<PlatformCreateDto, Platform>();
            CreateMap<PlatformReadDtos, PlatformPublishedDto>();
        }
    }
}
