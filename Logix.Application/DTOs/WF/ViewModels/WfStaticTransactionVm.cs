namespace Logix.Application.DTOs.WF.ViewModels
{
    public class WfStaticTransactionVm
    {
        public string FromUserName { get; set; }
        public string ToUserName { get; set; }
        public string StepName { get; set; }
        public string StatusName { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
