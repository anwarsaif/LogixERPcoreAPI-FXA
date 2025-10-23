using Logix.Application.DTOs.FXA;
using Logix.Domain.FXA;

namespace Logix.Application.Interfaces.IServices.FXA
{
    public interface IFxaTransactionsRevaluationService : IGenericQueryService<FxaTransactionsRevaluationDto, FxaTransactionsRevaluationVw>, IGenericWriteService<FxaTransactionsRevaluationDto, FxaTransactionsRevaluationEditDto>
    {
    }
}