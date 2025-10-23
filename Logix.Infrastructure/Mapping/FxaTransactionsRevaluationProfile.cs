using AutoMapper;
using Logix.Application.DTOs.FXA;
using Logix.Domain.FXA;

namespace Logix.Infrastructure.Mapping.FXA
{
    public class FxaTransactionsRevaluationProfile : Profile
    {
        public FxaTransactionsRevaluationProfile()
        {
            CreateMap<FxaTransactionsRevaluationDto, FxaTransactionsRevaluation>().ReverseMap();
            CreateMap<FxaTransactionsRevaluationEditDto, FxaTransactionsRevaluation>().ReverseMap();
        }
    }
}