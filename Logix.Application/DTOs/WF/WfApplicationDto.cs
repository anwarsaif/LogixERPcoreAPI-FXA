using Castle.MicroKernel.SubSystems.Conversion;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logix.Domain.WF;

namespace Logix.Application.DTOs.WF
{

    public class WfApplicationDto
    {
        public long Id { get; set; }
        public long? ApplicationCode { get; set; }
        public long? ApplicantsId { get; set; }
        public string? ApplicationDate { get; set; }
        public int? ApplicationsTypeId { get; set; }
        public int? StatusId { get; set; }
        public int? StepId { get; set; }
        public string? Note { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public bool? IsDeleted { get; set; }
        public string? DesNo { get; set; }
        public string? DesDate { get; set; }
        public string? Longitude { get; set; }
        public string? Latitude { get; set; }
        public long? AlternativeEmpId { get; set; }
        public long? BranchId { get; set; }
        public DateTime? DueDate { get; set; }
        public long? CustomerId { get; set; }
        public int? ProjectId { get; set; }
        public int? ProjectItemId { get; set; }
        public long? AuthorizedSignatory { get; set; }
        public string? Subject { get; set; }
        public string? ApplicantsName { get; set; }
    }
    public class WfApplicationEditDto
    {
        public long Id { get; set; }
        public long? ApplicationCode { get; set; }
        public long? ApplicantsId { get; set; }
        public string? ApplicationDate { get; set; }
        public int? ApplicationsTypeId { get; set; }
        public int? StatusId { get; set; }
        public int? StepId { get; set; }
        public string? Note { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? DesNo { get; set; }
        public string? DesDate { get; set; }
        public string? Longitude { get; set; }
        public string? Latitude { get; set; }
        public long? AlternativeEmpId { get; set; }
        public long? BranchId { get; set; }
        public DateTime? DueDate { get; set; }
        public long? CustomerId { get; set; }
        public int? ProjectId { get; set; }
        public int? ProjectItemId { get; set; }
        public long? AuthorizedSignatory { get; set; }
        public string? Subject { get; set; }
    }
    public class GetWfApplicationDto
    {
        public decimal? Allowance { get; set; }
        public decimal? Deduction { get; set; }
        public WfApplicationDto? appData { get; set; }
    }
    // DTO class to hold user email data
    public class UserEmailDto
    {
        public string? Email { get; set; }
        public string? Subject { get; set; }
        public long UserId { get; set; }
    }

    public class WfApplicationFilterDto
    {
        public long? UserId { get; set; }
        public long? DeptId { get; set; }
        public long? Location { get; set; }

        // ApplicationCode as long
        public long? appCode { get; set; }
        public string? ApplicantsName { get; set; }
        public string? ApplicationDate { get; set; }
        public int? StatusId { get; set; }
        public string? ApplicationCode { get; set; }
        public long? ApplicationsTypeId { get; set; }
        public int? SystemId { get; set; }
        public string? Subject { get; set; }
    }


    public class WfApplicationResultDto
    {
        public long Id { get; set; }
        public long? ApplicationCode { get; set; }
        public long? ApplicantsId { get; set; }
        public string? ApplicationDate { get; set; }
        public int? ApplicationsTypeId { get; set; }
        public int? StatusId { get; set; }
        public int? StepId { get; set; }
        public string? Note { get; set; }
        public bool? IsDeleted { get; set; }
        public string? DesNo { get; set; }
        public string? DesDate { get; set; }
        public string? Longitude { get; set; }
        public string? Latitude { get; set; }
        public long? AlternativeEmpId { get; set; }
        public long? BranchId { get; set; }
        public long? CustomerId { get; set; }
        public int? ProjectId { get; set; }
        public int? ProjectItemId { get; set; }
        public long? AuthorizedSignatory { get; set; }
        public string? Subject { get; set; }
        public string? ApplicantsName { get; set; }
        public string? ApplicationTypeName { get; set; }
    }
}
