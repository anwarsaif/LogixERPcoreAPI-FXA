using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.Main
{
    public partial class SysWebHookDto
    {
        public long? Id { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }

        public string? Url { get; set; }

        public int? MethodType { get; set; }

        public string? Header { get; set; }

        public string? Parameter { get; set; }

        public string? Body { get; set; }

        public string? Query { get; set; }

        public long? ScreenId { get; set; }

        public long? ProcessId { get; set; }

        public bool? IsEnabled { get; set; }

        public int? FacilityId { get; set; }

        public long? CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        public long? ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public string? QueryDetails { get; set; }

        public string? BodyDetails { get; set; }

        public bool? IsSecurityProtocol { get; set; }

        public bool? IsSuccessCodeInBody { get; set; }

        public string? PathSuccessCode { get; set; }

        public string? SuccessCode { get; set; }

        public string? LinkPage { get; set; }

        public long? AuthId { get; set; }

        public long? AppId { get; set; }
        public int? Status { get; set; }

        public bool? IsResendNewData { get; set; }
    }
    public partial class SysWebHookEditDto
    {
        public long Id { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }

        public string? Url { get; set; }

        public int? MethodType { get; set; }

        public string? Header { get; set; }

        public string? Parameter { get; set; }

        public string? Body { get; set; }

        public string? Query { get; set; }

        public long? ScreenId { get; set; }

        public long? ProcessId { get; set; }

        public bool? IsEnabled { get; set; }

        public int? FacilityId { get; set; }

        public long? CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        public long? ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool? IsDeleted { get; set; }

        public string? QueryDetails { get; set; }

        public string? BodyDetails { get; set; }

        public bool? IsSecurityProtocol { get; set; }

        public bool? IsSuccessCodeInBody { get; set; }

        public string? PathSuccessCode { get; set; }

        public string? SuccessCode { get; set; }

        public string? LinkPage { get; set; }

        public long? AuthId { get; set; }

        public long? AppId { get; set; }

        public bool? IsResendNewData { get; set; }
        public int? Status { get; set; }
    }

    public partial class SysWebHookFilterDto
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public long? ScreenId { get; set; }
        public long? SystemId { get; set; }
        public long? AppId { get; set; }
    }

    //public class SysWebHookDto
    //{
    //    public long Id { get; set; }

    //    public string? Name { get; set; }

    //    public string? Description { get; set; }

    //    public string? Url { get; set; }

    //    public int? MethodType { get; set; }

    //    public string? Header { get; set; }

    //    public string? Parameter { get; set; }

    //    public string? Body { get; set; }

    //    public string? Query { get; set; }
        
    //    public long? ScreenId { get; set; }
        
    //    public long? ProcessId { get; set; }

    //    public bool? IsEnabled { get; set; }
        
    //    public int? FacilityId { get; set; }

    //    public long? CreatedBy { get; set; }
        
    //    public DateTime? CreatedOn { get; set; }

    //    public long? ModifiedBy { get; set; }
       
    //    public DateTime? ModifiedOn { get; set; }

    //    public bool? IsDeleted { get; set; }

    //    public string? QueryDetails { get; set; }

    //    public string? BodyDetails { get; set; }

    //    public bool? IsSecurityProtocol { get; set; }

    //    public bool? IsSuccessCodeInBody { get; set; }

    //    public string? PathSuccessCode { get; set; }

    //    public string? SuccessCode { get; set; }
    //}
}