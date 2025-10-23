using Logix.Application.DTOs.FXA;
using Logix.Domain.FXA;

namespace Logix.Application.Interfaces.IServices.FXA
{
    public interface IFxaAdditionsExclusionService : IGenericQueryService<FxaAdditionsExclusionDto, FxaAdditionsExclusionVw>, IGenericWriteService<FxaAdditionsExclusionDto, FxaAdditionsExclusionEditDto>
    {

    }
}