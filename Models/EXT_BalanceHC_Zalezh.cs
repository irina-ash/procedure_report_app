using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace procedure_report_app.Models
{
    #nullable enable
    [Table("EXT_BalanceHC_Zalezh", Schema = "dbo")]
    public class EXT_BalanceHC_Zalezh 
    {
        [Key]
        public Guid GUID {get; set;}
        public Guid GUID_GeolObject {get; set;}
        public string PlastName {get; set;}
        public string ZalezhName {get; set;}
        public Guid GUID_License {get; set;}
        public float Depth_min {get; set;}
        public float Depth_max {get; set;}
        public Guid GUID_BalanceHC_Deposit {get; set;}
        public string AreaName {get; set;}
        public string Description {get; set;}
        public string Zone {get; set;}
        public Guid GUID_sNGK {get; set;}
        public Guid GUID_sObject_DepositType {get; set;}
        public Guid GUID_sCollectorType {get; set;}
        public int YearOpen {get; set;}
        public int YearDevelopment {get; set;}
        public string ReservesProtocol {get; set;}
        public byte IsUnallocatedFund {get; set;}
        public Guid GUID_CompanysOperator {get; set;}
        public Guid GUID_sOKPD {get; set;}
        public Guid GUID_sHCReserveAccountingType {get; set;}
    }
}