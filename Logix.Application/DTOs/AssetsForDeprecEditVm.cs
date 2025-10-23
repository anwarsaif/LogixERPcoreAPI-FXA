namespace Logix.Application.DTOs.FXA
{
    public class AssetsForDeprecEditVm
    {
        public long FxId { get; set; }
        public long FxNo { get; set; }
        public string? FxName { get; set; }
        public decimal DeprecValue { get; set; } = 0;
    }
}