using System;

namespace procedure_report_app.Models
{
    #nullable enable
    public class EXT_BalanceHC_Deposit
    {
        public required Guid GUID {get; set;}
        public required Guid GUID_Objects_Deposit {get; set;}
        public required Guid GUID_BalanceHC {get; set;}
        public required string ObjectName {get; set;}
        public required Guid GUID_sObjectState {get; set;}
        public required Guid GUID_sSub {get; set;}
        public string? Note {get; set;}
        public float Area {get; set;}
        public string? Placement {get; set;}
        public Guid GUID_sObject_DepositType {get; set;}
        public int YearOpen {get; set;}
        public int YearDevelopment {get; set;}
        public string? PromisingAreaType {get; set;}
    }
}