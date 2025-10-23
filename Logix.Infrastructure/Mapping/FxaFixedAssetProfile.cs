using AutoMapper;
using Logix.Application.DTOs.FXA;
using Logix.Domain.FXA;

namespace Logix.Infrastructure.Mapping.FXA
{
	public class FxaFixedAssetProfile : Profile
    {
        public FxaFixedAssetProfile()
        {
            CreateMap<FxaFixedAssetDto, FxaFixedAsset>().ReverseMap();
            CreateMap<FxaFixedAssetEditDto, FxaFixedAsset>().ReverseMap();

            //this mapping use when get assets to depreciation
            CreateMap<AssetsForDeprecVm, FxaFixedAssetVw>().ReverseMap();
        }
    }
}