namespace Logix.Application.DTOs.RPT
{
    public class RptReportFilterConditionDto
    {
        public string FieldName { get; set; } = "";
        public string OperatorFun { get; set; } = "";
        public string FieldValue { get; set; } = "";
    }
    public class RptReportFilterDto
    {

        public long Id { get; set; }

        public string? ReportName { get; set; }

        public string? ReportName2 { get; set; }

        public int? SystemId { get; set; }

        public int? ReportTable { get; set; }

        public string? ReportSearchFields { get; set; }
        public long? CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }
        public long? ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }

        public string? SysGroupId { get; set; }

        public string? OtherConditions { get; set; }

        public int? TypeId { get; set; }

        public string? ScreenUrl { get; set; }
    }

    public class RptReportDto
    {

        public long Id { get; set; }

        public string? ReportName { get; set; }

        public string? ReportName2 { get; set; }

        public int? SystemId { get; set; }

        public int? ReportTable { get; set; }

        public string? ReportSearchFields { get; set; }
        public long? CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }
        public long? ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }

        public string? SysGroupId { get; set; }

        public string? OtherConditions { get; set; }

        public int? TypeId { get; set; }

        public string? ScreenUrl { get; set; }
    }
    public class RptReportExpressAddDto
    {

        public long Id { get; set; }

        public string? ReportName { get; set; }

        public string? ReportName2 { get; set; }

        public int? SystemId { get; set; }

        public int? ReportTable { get; set; }

        public string? ReportSearchFields { get; set; }

        public string? SysGroupId { get; set; }

        public string? OtherConditions { get; set; }

        public int? TypeId { get; set; }

        public string? ScreenUrl { get; set; }
        public List<RptReportsFieldAddDto> Fields { get; set; } = new();

    }
    public class RptReportExternalLinkAddDto
    {

        public long Id { get; set; }

        public string? ReportName { get; set; }

        public string? ReportName2 { get; set; }

        public int? SystemId { get; set; }

        public int? ReportTable { get; set; }

        public string? ReportSearchFields { get; set; }

        public string? SysGroupId { get; set; }

        public string? OtherConditions { get; set; }

        public int? TypeId { get; set; }

        public string? ScreenUrl { get; set; }


    }
    public class RptReportBusinessIntelligenceAddDto
    {

        public long Id { get; set; }

        public string? ReportName { get; set; }

        public string? ReportName2 { get; set; }

        public int? SystemId { get; set; }

        public int? ReportTable { get; set; }

        public string? ReportSearchFields { get; set; }

        public string? SysGroupId { get; set; }

        public string? OtherConditions { get; set; }

        public int? TypeId { get; set; }

        public string? ScreenUrl { get; set; }
        public RptPowerBiconfigAddDto PowerBIConfig { get; set; } = new();

    }
}
