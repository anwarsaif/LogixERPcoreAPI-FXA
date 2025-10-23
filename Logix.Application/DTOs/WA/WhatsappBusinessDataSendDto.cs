namespace Logix.Application.DTOs.WA
{
    public class WhatsappBusinessDataSendDto
    {
        //يستخدم ك قالب   لي ارسال اي رساله
        public string RecipientPhoneNumber { get; set; }


       // public WaTemplateMessageValueDto WaTemplateMessageValue { get; set; }
        public string? Message { get; set; } 
        public object? DataMessage { get; set; }
        public bool HasDocument { get; set; } = false;
        public string DocumentUrl { get; set; }


    }
}
