using System;

namespace procedure_report_app.Models
{
     #nullable enable
     public class EXT_Companys
     {
        public required Guid GUID { get; set; }
        public required string Name {get; set;}
        public string? Ownership {get; set;} 
     }
}