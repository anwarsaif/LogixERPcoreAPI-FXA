
using Logix.Domain.OPM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logix.Application.DTOs.OPM
{
    public class PrintContractVM
    {
        //First Party Data
        public string? FirstParty { get; set; }
        public string? FirstPartyEn { get; set; }

        public string? FirstPartyName { get; set; }
        public string? FirstPartyEnName { get; set; }

        public string? FirstPartyJobName { get; set; }
        public string? IdentityTypeParty1 { get; set; }
        public string? IdentityNumberParty1 { get; set; }
        
        public string? FirstPartyAddress { get; set; }
        public string? FirstPartyPOBox { get; set; }

        //Second Party Data
        public string? SecondParty { get; set; }
        public string? SecondPartyEn { get; set; }

        public string? SecondPartyName { get; set; }
        public string? SecondPartyEnName { get; set; }

        public string? SecondPartyJobName { get; set; }
        public string? IdentityTypeParty2 { get; set; }
        public string? IdentityNumberParty2 { get; set; }
        public string? SecondPartyAddress { get; set; }
        public string? SecondPartyPOBox { get; set; }

        //Contract Data
        public List<OpmContractItemsVw> ContractItems { get; set; }
        public string? ContractDuration { get; set; }
        public string? ContractStartDate { get; set; }
        public int? NotificationDuration { get; set; }
        public bool AutoRenewal { get; set; }
        public string? DocumentNote { get; set; }
        public string? DeliveryTerm { get; set; }
        public string? PaymentTerms { get; set; }
        public string? PaymentTermsEN { get; set; }
        public string? ConditionsAddition { get; set; }
        public string? ConditionsAdditionEN { get; set; }
        public string? ContractTerms { get; set; }
        public string? ContractTermsEN { get; set; }
        public PrintContractVM()
        {
            ContractItems = new List<OpmContractItemsVw>();
            AutoRenewal = false;
        }
    }
}
