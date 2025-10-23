using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.PM.PmExtractAdditionalType
{
    public class PmExtractAdditionalTypeDto
    {

        public long Id { get; set; }
        public long? Code { get; set; }
        public int? TypeId { get; set; }
        public string? Name { get; set; }
        public int? CreditOrDebit { get; set; }
        public int? RateOrAmount { get; set; }
        public decimal? Rate { get; set; }
        public decimal? Amount { get; set; }
        public long? AccountId { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }
        public int? TotalOrNet { get; set; }
        public int? FacilityId { get; set; }

        public int? EncludRate { get; set; }

        public long? AccRefTypeId { get; set; }
        public string? AccAccountCode { get; set; }//  فقط  وقت الاضافة 
    }


    public class PmExtractAdditionalTypeEditDto
    {
        public long Id { get; set; }
        public long? Code { get; set; }
        public int? TypeId { get; set; }
        public string? Name { get; set; }
        public int? CreditOrDebit { get; set; }
        public int? RateOrAmount { get; set; }
        public decimal? Rate { get; set; }
        public decimal? Amount { get; set; }
        public long? AccountId { get; set; }

/*        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsDeleted { get; set; }*/
        public int? TotalOrNet { get; set; }
        public int? FacilityId { get; set; }

        public int? EncludRate { get; set; }

        public long? AccRefTypeId { get; set; }
        public string? AccAccountCode { get; set; }//  يتم  جلب رقم الحساب حسب الكود 

    }
}
