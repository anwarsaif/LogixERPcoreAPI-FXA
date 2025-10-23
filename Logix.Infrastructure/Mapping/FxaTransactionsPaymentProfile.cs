using AutoMapper;
using Logix.Application.DTOs.FXA;
using Logix.Domain.FXA;

namespace Logix.Infrastructure.Mapping.FXA
{
	public class FxaTransactionsPaymentProfile : Profile
    {
        public FxaTransactionsPaymentProfile()
        {
            CreateMap<FxaTransactionsPaymentDto, FxaTransactionsPayment>().ReverseMap();
            CreateMap<FxaTransactionsPaymentEditDto, FxaTransactionsPayment>().ReverseMap();

            //this mapping use when get assets to depreciation
           // CreateMap<AssetsForDeprecVm, FxaFixedAssetVw>().ReverseMap();
        }
    }
}