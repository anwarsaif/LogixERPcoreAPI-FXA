using AutoMapper;
using Logix.Application.DTOs.FXA;
using Logix.Domain.FXA;

namespace Logix.Infrastructure.Mapping.FXA
{
    public class FxaTransactionProfile : Profile
    {
        public FxaTransactionProfile()
        {
            CreateMap<FxaTransactionDto, FxaTransaction>().ReverseMap();
            CreateMap<FxaTransactionEditDto, FxaTransaction>().ReverseMap();

            CreateMap<FxaTransactionFxaTransactionsAssetDto, FxaTransaction>().ReverseMap();
        }
    }
}