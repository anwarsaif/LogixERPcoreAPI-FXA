using AutoMapper;
using Logix.Application.DTOs.FXA;
using Logix.Domain.FXA;

namespace Logix.Infrastructure.Mapping.FXA
{
    public class FxaFixedAssetTransferProfile : Profile
    {
        public FxaFixedAssetTransferProfile()
        {
            CreateMap<FxaFixedAssetTransferDto, FxaFixedAssetTransfer>().ReverseMap();
            CreateMap<FxaFixedAssetTransferEditDto, FxaFixedAssetTransfer>().ReverseMap();
            CreateMap<FxaFixedAssetTransferDto2, FxaFixedAssetTransfer>().ReverseMap();
        }
    }
}