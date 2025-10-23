namespace Logix.Application.DTOs.WF.ViewModels
{
    public class WfTransactionVm
    {
        public int Id { get; set; }
        public string SenderName { get; set; }
        public string ReceiverName { get; set; }
        public string StepName { get; set; }
        public string StatusName { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
