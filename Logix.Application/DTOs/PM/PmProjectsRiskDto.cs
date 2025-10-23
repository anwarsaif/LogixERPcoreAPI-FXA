using Logix.Application.DTOs.Main;
using System.ComponentModel.DataAnnotations;

namespace Logix.Application.DTOs.PM
{

    public partial class PmProjectsRiskAddDto
    {

        public long Id { get; set; } = 0;// TCode
        [StringLength(10)]
        public string? Date { get; set; }
        [Required]
        public long? ProjectCode { get; set; } // then get project by this project code 
        public int? TypeId { get; set; }
        // public long? EmpId { get; set; } get value from session
        [Required]
        public decimal? RiskRate { get; set; }
        public int? Effect { get; set; } = 0;//DDlRisksEffect
        public int? Impact { get; set; } = 0;//DDlRisksImpact
        [Required]
        public int? Significance { get; set; } //مدى أهمية الخطر
        public string? PlannedDate { get; set; }//التاريخ المخطط لمعالجة الخطر

        public int? StatusId { get; set; }
        [Required]
        public string? ActionsPlans { get; set; }//لأعمال والخطط اللازمة لمعالجة الخطر
        [Required]
        public string? Description { get; set; }//وصف الخطر
        public string? Details { get; set; }//الاثر المتوقع
        [Required]
        public string? RequiredSupport { get; set; }//الدعم المطلوب"
        public int? AppTypeID { get; set; } = 0;//not in database 

        // يستخدم عملية الحفظ الملفات  الداله العامة 
        //*****
        public List<SaveFileDto> FileList { get; set; } = new List<SaveFileDto>();

    }
    public partial class PmProjectsRiskEditDto
    {

        public long Id { get; set; } = 0;// TCode
        [StringLength(10)]
        public string? Date { get; set; }
        [Required]
        public long? ProjectCode { get; set; } // then get project by this project code 
        public long? ProjectId { get; set; }
        public int? TypeId { get; set; }
        // public long? EmpId { get; set; } get value from session
        [Required]
        public decimal? RiskRate { get; set; }
        public int? Effect { get; set; } = 0;//DDlRisksEffect
        public int? Impact { get; set; } = 0;//DDlRisksImpact
        [Required]
        public int? Significance { get; set; } //مدى أهمية الخطر
        public string? PlannedDate { get; set; }//التاريخ المخطط لمعالجة الخطر

        public int? StatusId { get; set; }
        [Required]
        public string? ActionsPlans { get; set; }//لأعمال والخطط اللازمة لمعالجة الخطر
        [Required]
        public string? Description { get; set; }//وصف الخطر
        public string? Details { get; set; }//الاثر المتوقع
        [Required]
        public string? RequiredSupport { get; set; }//الدعم المطلوب"
                                                    // public int? AppTypeID { get; set; } = 0;//not in database 

        // يستخدم عملية الحفظ الملفات  الداله العامة 
        public List<SaveFileDto> FileList { get; set; } = new List<SaveFileDto>();
        // عرض 
        public string? ProjectName { get; set; }
        public string? EmpCode { get; set; }
        public string? EmpName { get; set; }


    }

    public partial class PmProjectsRiskFilterDto
    {

        public long? Id { get; set; } = 0;// TCode

        public long? ProjectCode { get; set; }
        public string? ProjectName { get; set; }
        public int? Effect { get; set; } = 0;//DDlRisksEffect
        public int? Impact { get; set; } = 0;//DDlRisksImpact
        public string? DateFrom { get; set; }// غير موجودين في الجدول او لافيو 
        public string? DateTo { get; set; }//*****

        public string? EmpCode { get; set; } //="0";
        public string? EmpName { get; set; }
        public long? WbsId { get; set; } = 0;

        public long? ActivityId { get; set; } = 0;
    }

    public class PmProjectsRiskDto
    {
        public long Id { get; set; }
        [StringLength(10)]
        public string? Date { get; set; }
        public long? ProjectId { get; set; } = 0;
        public long? WbsId { get; set; } = 0;

        public long? ActivityId { get; set; } = 0;
        public long? EmpId { get; set; } = 0;
        public string? Details { get; set; }
        public string? Description { get; set; }
        public long? AppId { get; set; } = 0;
        public long? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; } = false;
        public int? StatusId { get; set; } = 0;

        public decimal? RiskRate { get; set; } = 0;
        public int? TypeId { get; set; } = 0;
        public int? Effect { get; set; } = 0;
        public int? Impact { get; set; } = 0;
        public string? RequiredSupport { get; set; }

        public string? PlannedDate { get; set; }
        public string? ActionsPlans { get; set; }
        public int? Significance { get; set; } = 0;
    }
    /*    
        public class PmProjectsRiskEditDto
        {
            public long Id { get; set; }
            [StringLength(10)]
            public string? Date { get; set; }
          [Required]

            public long? ProjectId { get; set; }
            public long? WbsId { get; set; }

            public long? ActivityId { get; set; }
            public long? EmpId { get; set; }
            public string? Details { get; set; }
            public string? Description { get; set; }
            public long? AppId { get; set; }
            public long? CreatedBy { get; set; }
            public DateTime? CreatedOn { get; set; }
            public long? ModifiedBy { get; set; }
            public DateTime? ModifiedOn { get; set; }
            public bool? IsDeleted { get; set; }
            public int? StatusId { get; set; }

            public decimal? RiskRate { get; set; }
            public int? TypeId { get; set; }
            public int? Effect { get; set; }
            public int? Impact { get; set; }
            public string? RequiredSupport { get; set; }

            public string? PlannedDate { get; set; }
            public string? ActionsPlans { get; set; }
            public int? Significance { get; set; }
        }*/


    public partial class PmProjectsRisk2Dto
    {
        public long Id { get; set; }
        public int? Effect { get; set; }
        public int? Impact { get; set; }
        public long? EmpId { get; set; }
        public string? Description { get; set; }
        public long? ProjectId { get; set; }

    }
}
