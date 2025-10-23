using Logix.Application.DTOs.FXA;
using Logix.Application.Wrapper;
using Logix.Domain.FXA;

namespace Logix.Application.Interfaces.IServices.FXA
{
    public interface IFxaTransactionService : IGenericQueryService<FxaTransactionDto, FxaTransactionsVw>, IGenericWriteService<FxaTransactionDto, FxaTransactionEditDto>
    {
        #region ======================================================= Asset Exclusion (asset sale) =======================================================
        Task<IResult<FxaTransactionDto_Sale>> Add_Sale(FxaTransactionDto_Sale entity, CancellationToken cancellationToken = default);
        Task<IResult<FxaTransactionDto_Sale>> Update_Sal(FxaTransactionDto_Sale entity, CancellationToken cancellationToken = default);
        #endregion ======================================================= End Asset Exclusion =======================================================


        #region ======================================================= Asset Depreciation =======================================================
        Task<IResult<AssetsDeprecAddDto>> Add_Depreciation(AssetsDeprecAddDto entity, CancellationToken cancellationToken = default);

        #endregion ======================================================= End Asset Depreciation =======================================================


        #region ======================================================= Asset Revaluation =======================================================
        Task<IResult<FxaTransactionDto_Revaluation>> Add_Revaluation(FxaTransactionDto_Revaluation entity, CancellationToken cancellationToken = default);

        #endregion ======================================================= End Asset Revaluation =======================================================


        // this function to delete transactions (exclusion, depreciation, ...) based on DocTypeId
        Task<IResult> RemoveTransaction(long Id,int DocTypeId, CancellationToken cancellationToken = default);
    }
}