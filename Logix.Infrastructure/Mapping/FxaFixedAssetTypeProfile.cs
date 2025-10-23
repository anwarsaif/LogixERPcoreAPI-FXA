using AutoMapper;
using Logix.Application.DTOs.FXA;
using Logix.Domain.FXA;

namespace Logix.Infrastructure.Mapping.FXA
{
    public class FxaFixedAssetTypeProfile : Profile
    {
        public FxaFixedAssetTypeProfile()
        {
            CreateMap<FxaFixedAssetTypeDto, FxaFixedAssetType>().ReverseMap();
            CreateMap<FxaFixedAssetTypeEditDto, FxaFixedAssetType>().ReverseMap();
        }
    }
}