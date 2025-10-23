using AutoMapper;
using Logix.Application.DTOs.FXA;
using Logix.Domain.FXA;

namespace Logix.Infrastructure.Mapping.FXA
{
    public class FxaTransactionsAssetProfile : Profile
    {
        public FxaTransactionsAssetProfile()
        {
            CreateMap<FxaTransactionsAssetDto, FxaTransactionsAsset>().ReverseMap();
            CreateMap<FxaTransactionsAssetEditDto, FxaTransactionsAsset>().ReverseMap();

            CreateMap<FxaTransactionFxaTransactionsAssetDto, FxaTransactionsAsset>().ReverseMap();
        }
    }
}