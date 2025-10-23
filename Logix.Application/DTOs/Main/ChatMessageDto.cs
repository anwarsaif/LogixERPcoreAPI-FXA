namespace Logix.Application.DTOs.Main
{
    public class ChatMessageDto
    {
        public long? Id { get; set; }
        public string? MessageText { get; set; }
        public int? SenderId { get; set; }
        public int? ReceiverId { get; set; }
        public bool? MessageStatus { get; set; }
        public bool? IsRead { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
    public class ChatMessageEditDto
    {
        public long Id { get; set; }
        public string? MessageText { get; set; }
        public int? SenderId { get; set; }
        public int? ReceiverId { get; set; }
        public bool? MessageStatus { get; set; }
        public bool? IsRead { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
