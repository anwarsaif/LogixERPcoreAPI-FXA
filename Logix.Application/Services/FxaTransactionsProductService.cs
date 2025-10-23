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
    public class FxaTransactionsProductService : GenericQueryService<FxaTransactionsProduct, FxaTransactionsProductDto, FxaTransactionsProductsVw>, IFxaTransactionsProductService
    {
        public FxaTransactionsProductService(IQueryRepository<FxaTransactionsProduct> queryRepository,
            IMapper mapper) : base(queryRepository, mapper)
        {
        }

        public Task<IResult<FxaTransactionsProductDto>> Add(FxaTransactionsProductDto entity, CancellationToken cancellationToken = default)
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

        public Task<IResult<FxaTransactionsProductEditDto>> Update(FxaTransactionsProductEditDto entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}