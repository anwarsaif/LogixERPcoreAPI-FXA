namespace Logix.Application.DTOs.WA
{
    public class WhatsappBusinessDataSendModel
    {
       // يستخدم  لي البيانات المرسلة اللى  repo
       // 
      
        public string? RecipientPhoneNumber { get; set; }
        public string? TextMessage { get; set; }
        public string? DocumentUrl { get; set; }
        public string? Filename { get; set; }
    }  
}
