namespace Logix.Application.DTOs.PUR
{
    public class PurRqfWorkFlowEvaluationDto
    {
        public long? Id { get; set; }
        public long? TransactionId { get; set; }
        public int? CntTechnicalMembers { get; set; }
        public int? CntTechnicalMembersEvaluation { get; set; }
        public string? TechnicalMembersEmpId { get; set; }
        public string? TechnicalMembersEmpIdEvaluation { get; set; }
        public int? CntCommitteeMembers { get; set; }
        public int? CntCommitteeMembersEvaluation { get; set; }
        public string? CommitteeMembersEmpId { get; set; }
        public string? CommitteeMembersEmpIdEvaluation { get; set; }
        public int? DecisionMaker1EmpId { get; set; }
        public int? DecisionMaker1EmpIdApprove { get; set; }
        public int? DecisionMaker2EmpId { get; set; }
        public int? DecisionMaker2EmpIdApprove { get; set; }
        public int? CommitteeChairmanEmpId { get; set; }
        public int? CommitteeChairmanEmpIdEvaluation { get; set; }
        public bool? IsCreatePo { get; set; }
        public int? EmpIdCreatePo { get; set; }

        public bool? IsDeleted { get; set; }
        public long? UserChange { get; set; }
        public string? NoteChage { get; set; }
    }
    public class PurRqfWorkFlowEvaluationEditDto
    {
        public long Id { get; set; }
        public long? TransactionId { get; set; }
        public int? CntTechnicalMembers { get; set; }
        public int? CntTechnicalMembersEvaluation { get; set; }
        public string? TechnicalMembersEmpId { get; set; }
        public string? TechnicalMembersEmpIdEvaluation { get; set; }
        public int? CntCommitteeMembers { get; set; }
        public int? CntCommitteeMembersEvaluation { get; set; }
        public string? CommitteeMembersEmpId { get; set; }
        public string? CommitteeMembersEmpIdEvaluation { get; set; }
        public int? DecisionMaker1EmpId { get; set; }
        public int? DecisionMaker1EmpIdApprove { get; set; }
        public int? DecisionMaker2EmpId { get; set; }
        public int? DecisionMaker2EmpIdApprove { get; set; }
        public int? CommitteeChairmanEmpId { get; set; }
        public int? CommitteeChairmanEmpIdEvaluation { get; set; }
        public bool? IsCreatePo { get; set; }
        public int? EmpIdCreatePo { get; set; }
        public long? UserChange { get; set; }
        public string? NoteChage { get; set; }
    }
}
