using AutoMapper;
using Logix.Application.DTOs.FXA;
using Logix.Domain.FXA;

namespace Logix.Infrastructure.Mapping.FXA
{
    public class FxaTransactionsProductProfile : Profile
    {
        public FxaTransactionsProductProfile()
        {
            CreateMap<FxaTransactionsProductDto, FxaTransactionsProduct>().ReverseMap();
            CreateMap<FxaTransactionsProductEditDto, FxaTransactionsProduct>().ReverseMap();
        }
    }
}