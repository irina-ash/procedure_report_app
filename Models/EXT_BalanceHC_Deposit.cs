using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace procedure_report_app.Models
{
    #nullable enable
    [Table("EXT_BalanceHC_Deposit", Schema = "dbo")]
    public class EXT_BalanceHC_Deposit
    {
        [Key]
        public Guid GUID {get; set;}
        public Guid GUID_Objects_Deposit {get; set;}
        public Guid GUID_BalanceHC {get; set;}
        public string ObjectName {get; set;}
        public Guid GUID_sObjectState {get; set;}
        public Guid GUID_sSub {get; set;}
        public string Note {get; set;}
        public float Area {get; set;}
        public string? Placement {get; set;}
        public Guid GUID_sObject_DepositType {get; set;}
        public int YearOpen {get; set;}
        public int YearDevelopment {get; set;}
        public string PromisingAreaType {get; set;}
    }
}