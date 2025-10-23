using System.ComponentModel.DataAnnotations;

namespace Logix.Application.DTOs.PM
{
    public class PmProjectsDeliverableDto
    {
        public long? Id { get; set; }
        public string? Name { get; set; }
        public long? ProjectId { get; set; }
        public long? ProjectCode { get; set; }
        public string? Type { get; set; }
        public decimal? Qty { get; set; }
        public string? Description { get; set; }
        public string? Note { get; set; }
        public bool? IsDeleted { get; set; }
        public string? DeliveryDateT { get; set; }
        public string? DeliveryDate { get; set; }
        public decimal? Percentage { get; set; }
        public decimal? Cost { get; set; }
        public int? StatusId { get; set; }
        public long? PItemId { get; set; }
        public string? FileUrl { get; set; }
        public string? FilePdf { get; set; }
        public string? PathFile { get; set; }
        public int? AddTrack { get; set; }
    }
    public class PmProjectsDeliverableEditDto
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public long? ProjectId { get; set; }
        public long? ProjectCode { get; set; }
        public string? Type { get; set; }
        public decimal? Qty { get; set; }
        public string? Description { get; set; }
        public string? Note { get; set; }
        public string? DeliveryDateT { get; set; }
        public string? DeliveryDate { get; set; }
        public decimal? Percentage { get; set; }
        public decimal? Cost { get; set; }
        public int? StatusId { get; set; }
        public long? PItemId { get; set; }
        public string? FileUrl { get; set; }
        public string? FilePdf { get; set; }
        public string? PathFile { get; set; }
    }

    public class ProjectsDeliverablePopUpDto
    {
        public long? Id { get; set; }
        public long? TransId { get; set; }
        public string? Name { get; set; }
        public decimal? Qty { get; set; }
        public decimal? ApproveQty { get; set; }
        public decimal? PreviousQty { get; set; }
    }

    public partial class PmProjectsDeliverableFilterDto
    {
        public long? Id { get; set; }
        public string? Name { get; set; }

        public long? ProjectCode { get; set; }
        public string? ProjectName { get; set; }

        public string? From { get; set; }
        public string? To { get; set; }

        public string? CustomerName { get; set; }

        public string? CustomerCode { get; set; }

        public string? ItemName { get; set; }
        public string? Note { get; set; }


    }

    public  class PmProjectsDeliverableChangeStatusDto
    {
        public List<long> Ids { get; set; }
        public int StatusId { get; set; }
        public string? Note { get; set; }
        public string? FileUrl { get; set; }


    }
    public class ProjectDeliverablesDefinitionDto
    {
        public long Id { get; set; }
        public decimal Qty { get; set; }
        public string Date { get; set; }
        public int PaymentId{ get; set; }


    }
}
