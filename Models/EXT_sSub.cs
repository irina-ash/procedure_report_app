using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace procedure_report_app.Models
{
     #nullable enable
     [Table("EXT_sSub", Schema = "dbo")]
     public class EXT_sSub
     {
        [Key]       
        public required Guid GUID {get; set;}
        public required string SubName {get; set;}
        public string? SubShort_Name {get; set;}
        public int SortOrder {get; set;}
        public Guid GUID_sFederalDistrict {get; set;}
     }
}