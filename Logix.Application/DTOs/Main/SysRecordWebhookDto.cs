namespace Logix.Application.DTOs.Main
{

    public class SysRecordWebhookDto
    {
        public long? Id { get; set; }

        public long? WebHookId { get; set; }

        public string? ErrorReason { get; set; }

        public string? ErrorCode { get; set; }

        public string? Data { get; set; }

        public long? CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        public long? ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public bool? IsSended { get; set; }

        public string? ReferenceId { get; set; }

        public string? LinkPage { get; set; }
    }
    public class SysRecordWebhookEditDto
    {
        public long Id { get; set; }

        public long? WebHookId { get; set; }

        public string? ErrorReason { get; set; }

        public string? ErrorCode { get; set; }

        public string? Data { get; set; }

        public long? CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        public long? ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public bool? IsSended { get; set; }

        public string? ReferenceId { get; set; }

        public string? LinkPage { get; set; }
    }
    
    //public class SysRecordWebhookDto
    //{
    //    public long Id { get; set; }
    //    public long? WebHookId { get; set; }
    //    public string? ErrorReason { get; set; }
    //    public string? ErrorCode { get; set; }
    //    public string? Data { get; set; }
    //    public long? CreatedBy { get; set; }
    //    public DateTime? CreatedOn { get; set; }
    //    public bool? IsDeleted { get; set; }
    //    public bool? IsSended { get; set; }
    //}

    //public class SysRecordWebhookEditDto
    //{
    //    public long Id { get; set; }
    //    public long? WebHookId { get; set; }
    //    public string? ErrorReason { get; set; }
    //    public string? ErrorCode { get; set; }
    //    public string? Data { get; set; }
    //    public long? ModifiedBy { get; set; }
    //    public DateTime? ModifiedOn { get; set; }
    //    public bool? IsSended { get; set; }
    //}
    
    public class SysRecordWebhookFilterDto
    {
        public string? Name { get; set; }
        public string? ErrorCode { get; set; }
        public int? IsSended { get; set; }
        public long? AppId { get; set; }
        public string? ReferenceId { get; set; }
        public long? ScreenId { get; set; }
        public long? SystemId { get; set; }
    }
    //public class SelectedItemIdsListDto
    //{
    //    public List<long> Id { get; set; }
    //}

}
