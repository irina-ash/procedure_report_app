using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace procedure_report_app.Models
{
     #nullable enable
    [Table("EXT_BalanceHC_ZapasCategory", Schema = "dbo")] 
    public class EXT_BalanceHC_ZapasCategory
    {
        [Key]
        public required Guid GUID { get; set; }
        public required float zapaspredyeargeo {get; set;}
        public required float zapaspredyearizvl {get; set;}
        public required float dobicha {get; set;}
        public required float poteri {get; set;}
        public required float razvedkageo {get; set;}
        public required float razvedkaizvl {get; set;}
        public required float pereocenkageo {get; set;}
        public required float pereocenkaizvl {get; set;}
        public required float peredachageo {get; set;}
        public required float peredachaizvl {get; set;}
        public required float zapastekyeargeo {get; set;}
        public required float zapastekyearizvl {get; set;}
        public required float utvzapasgeo {get; set;}
        public required float utvzapasizvl {get; set;}
        public required float dobnacsnach {get; set;}
        public required float potnacsnach {get; set;}
        public required float dobnacsutv {get; set;}
        public required float potnacsutv {get; set;}
        public float nach_soder {get; set;}
        public float tek_soder {get; set;}
        public required Guid GUID_sProductComponent {get; set;}
        public required float zakachsnach {get; set;}
        public required float zakach {get; set;}
        public required Guid GUID_GeolObject_KategZalezh {get; set;}
        public required float DobNacSNachEndYear {get; set;}
        public required float PotNacSNachEndYear {get; set;}
        public required float ZakachSNachEndYear {get; set;}
        public required float ZapasPredYearEconomic {get; set;}
        public required float RazvedkaEconomic {get; set;}
        public required float PereocenkaEconomic {get; set;}
        public required float PeredachaEconomic {get; set;}
        public required float ZapasTekYearEconomic {get; set;}
        public required float UtvZapasEconomic {get; set;}
        public required float OFCumulativeExtracted {get; set;}
        public required float OFCumulativeLosses {get; set;}
        public required float OFCumulativePumped {get; set;}
    }
}