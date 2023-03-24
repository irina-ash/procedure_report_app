using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace procedure_report_app.Models
{
     #nullable enable
     [Table("EXT_Companys", Schema = "dbo")]
     public class EXT_Companys
     {
        [Key]
        public required Guid GUID { get; set; }
        public required string Name {get; set;}
        public string? Ownership {get; set;} 
     }
}