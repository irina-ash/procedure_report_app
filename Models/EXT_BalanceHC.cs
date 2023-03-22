using System;
using System.ComponentModel.DataAnnotations;

namespace procedure_report_app.Models
{
    #nullable enable
    public class EXT_BalanceHC
    {
        [Key]
        public required Guid GUID { get; set; }
        public required int YearBalance { get; set; }
        public Guid GUID_Company { get; set; }
        public string? Responsible { get; set; }
        public required Guid GUID_sBalanceStatus { get; set; }
        public string? Note { get; set; }
        public int IsStateBalance { get; set; }
        public Guid GUID_Responsible { get; set; }
        public DateTime DateChanged { get; set; }
    }
}