using AutoMapper;
using Logix.Application.DTOs.FXA;
using Logix.Domain.FXA;

namespace Logix.Infrastructure.Mapping.FXA
{
    public class FxaAdditionsExclusionTypeProfile : Profile
    {
        public FxaAdditionsExclusionTypeProfile()
        {
            CreateMap<FxaAdditionsExclusionTypeDto, FxaAdditionsExclusionType>().ReverseMap();
        }
    }
}