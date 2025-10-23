using AutoMapper;
using Logix.Application.DTOs.FXA;
using Logix.Domain.FXA;

namespace Logix.Infrastructure.Mapping.FXA
{
    public class FxaTransactionsTypeProfile : Profile
    {
        public FxaTransactionsTypeProfile()
        {
            CreateMap<FxaTransactionsTypeDto, FxaTransactionsType>().ReverseMap();
        }
    }
}