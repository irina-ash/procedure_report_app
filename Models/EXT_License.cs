using System;
using System.ComponentModel.DataAnnotations;

namespace procedure_report_app.Models
{
     #nullable enable
     public class EXT_License
     {
        [Key] 
        public required Guid GUID { get; set; }
        public Guid GUID_Companys {get; set;}
        public required Guid GUID_LicensePart {get; set;} 
        public string? Series {get; set;}
        public string? Number {get; set;}
        public string? Type {get; set;}
        public string? TargetUse {get; set;}
        public string? ProductType {get; set;}
        public string? ProductTypeSecond {get; set;}
        public Guid GUID_sLicenseStatus {get; set;}
        public Guid GUID_sLicenseState {get; set;}
        public DateTime DateBegin {get; set;}
        public DateTime DateEnd {get; set;}
        public DateTime DateAnnulment {get; set;}
        public int IsUnlimited {get; set;}
        public string? ConfirmingOrg {get; set;}
        public float AreaByDocument {get; set;}
        public string? MiningAllotmenteLimit {get; set;}
        public string? GeoAllotmenteLimit {get; set;}
        public required Guid GUID_sProductGroup {get; set;}
        public Guid GUID_PreviousLicense {get; set;}
        public Guid GUID_sSub {get; set;}
        public string? Description {get; set;}
        public string? PartName {get; set;}
        public string? JustificationReceiving {get; set;}
        public string? NumberForm {get; set;}
        public string? JustificationReturning {get; set;}
        public Guid GUID_sLicenseForm {get; set;}
        public string? NumberRequest {get; set;}
        public DateTime DateRequest {get; set;}
        public DateTime DateBeginWork {get; set;}
        public Guid guid_sTargetUse {get; set;}
        public Guid guid_sDirectionProductGroup {get; set;}
        public Guid GUID_sLicenseAgreementReason {get; set;}
     }
}