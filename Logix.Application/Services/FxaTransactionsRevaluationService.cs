using AutoMapper;
using Logix.Application.DTOs.FXA;
using Logix.Application.Interfaces.IRepositories;
using Logix.Application.Interfaces.IServices.FXA;
using Logix.Application.Wrapper;
using Logix.Domain.FXA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.Services.FXA
{
    public class FxaTransactionsRevaluationService : GenericQueryService<FxaTransactionsRevaluation, FxaTransactionsRevaluationDto, FxaTransactionsRevaluationVw>, IFxaTransactionsRevaluationService
    {
        public FxaTransactionsRevaluationService(IQueryRepository<FxaTransactionsRevaluation> queryRepository,
            IMapper mapper) : base(queryRepository, mapper)
        {
        }

        public Task<IResult<FxaTransactionsRevaluationDto>> Add(FxaTransactionsRevaluationDto entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> Remove(long Id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> Remove(int Id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IResult<FxaTransactionsRevaluationEditDto>> Update(FxaTransactionsRevaluationEditDto entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
