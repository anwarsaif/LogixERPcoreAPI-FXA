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
    public class FxaTransactionsAssetService : GenericQueryService<FxaTransactionsAsset, FxaTransactionsAssetDto, FxaTransactionsAssetsVw>, IFxaTransactionsAssetService
    {
        public FxaTransactionsAssetService(IQueryRepository<FxaTransactionsAsset> queryRepository,
            IMapper mapper) : base(queryRepository, mapper)
        {
        }

        public Task<IResult<FxaTransactionsAssetDto>> Add(FxaTransactionsAssetDto entity, CancellationToken cancellationToken = default)
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

        public Task<IResult<FxaTransactionsAssetEditDto>> Update(FxaTransactionsAssetEditDto entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}