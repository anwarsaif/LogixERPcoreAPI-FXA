using AutoMapper;
using Logix.Application.DTOs.FXA;
using Logix.Domain.FXA;

namespace Logix.Infrastructure.Mapping.FXA
{
    public class FxaAdditionsExclusionProfile : Profile
    {
        public FxaAdditionsExclusionProfile()
        {
            CreateMap<FxaAdditionsExclusionDto, FxaAdditionsExclusion>().ReverseMap();
            CreateMap<FxaAdditionsExclusionEditDto, FxaAdditionsExclusion>().ReverseMap();
        }
    }
}