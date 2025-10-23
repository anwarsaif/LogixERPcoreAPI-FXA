namespace Logix.Application.DTOs.OPM
{
    public class OPMPayrollDDto
    {


        public long MsdId { get; set; }

        public long MsId { get; set; }

        public string? JobId { get; set; }

        public long? EmpId { get; set; }

        public decimal? Salary { get; set; }

        public string? EmpAccountNo { get; set; }
        public int? BankId { get; set; }

        public int? CountDayWork { get; set; }

        public decimal? Allowance { get; set; }

        public decimal? Deduction { get; set; }

        public decimal? Absence { get; set; }

        public decimal? Delay { get; set; }

        public decimal? Loan { get; set; }

        public decimal? TransactionInstallment { get; set; }

        public decimal? Net { get; set; }

        public string? Note { get; set; }
        public long? CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }
        public long? ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }
        public bool IsDeleted { get; set; }

        public decimal? Commission { get; set; }

        public decimal? OverTime { get; set; }

        public decimal? Mandate { get; set; }

        public decimal? HOverTime { get; set; }

        public decimal? HDelay { get; set; }

        public decimal? Penalties { get; set; }

        public decimal? SalaryOrignal { get; set; }

        public long? RefranceNo { get; set; }

        public long? DeptId { get; set; }

        public long? LocationId { get; set; }

        public long? FacilityId { get; set; }

        public long? BranchId { get; set; }

        public long? SalaryGroupId { get; set; }

        public long? CcId { get; set; }

        public int? CntAbsence { get; set; }

        public int? PaymentTypeId { get; set; }

        public int? WagesProtection { get; set; }

        public decimal? AllowanceOrignal { get; set; }

        public decimal? DeductionOrignal { get; set; }

        public string? Iban { get; set; }
        public string? EmpCode { get; set; }
        public string? EmpName { get; set; }
        public string? EmpName2 { get; set; }
        public string? ContractCode { get; set; }
        public string? LocationName { get; set; }

        public string? LocationName2 { get; set; }
        public long? ContractId { get; set; }
        public bool IsSelected { get; set; }
        public long? ItemsId { get; set; }
        public decimal? HOverPrice { get; set; }
        public decimal? Absenceprice { get; set; }
        public string? CatagoriesName { get; set; }

        public string? CatagoriesName2 { get; set; }

    }
}
