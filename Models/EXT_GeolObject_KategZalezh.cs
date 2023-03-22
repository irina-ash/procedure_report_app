using System;

namespace procedure_report_app.Models
{
     #nullable enable
     public class EXT_GeolObject_KategZalezh
     {
        public required Guid GUID { get; set; }
        public required int typezalezh {get; set;}
        public required string category {get; set;}
        public string? zone {get; set;}
        public float area {get; set;}
        public float oilwidthmin {get; set;}
        public float oilwidthmax {get; set;}
        public float efectivwidthmin {get; set;}
        public float efectivwidthmax {get; set;}
        public float koafporistmin {get; set;}
        public float koafporistmax {get; set;}
        public float koafnasischenmin {get; set;}
        public float koafnasischenmax {get; set;}
        public float koafizvlechmin {get; set;}
        public float koafizvlechmax {get; set;}
        public float koafizvlechgazmin {get; set;}
        public float koafizvlechgazmax {get; set;}
        public float pronicaemostmin {get; set;}
        public float pronicaemostmax {get; set;}
        public float pereschetkoafmin {get; set;}
        public float pereschetkoafmax {get; set;}
        public float davlplastmin {get; set;}
        public float davlplastmax {get; set;}
        public float gazfaktormin {get; set;}
        public float gazfaktormax {get; set;}
        public required Guid GUID_BalanceHC_Zalezh {get; set;}
        public float Volume {get; set;}
        public float KoafIzvlechEconomicMin {get; set;}
        public float KoafIzvlechEconomicMax {get; set;}
        public float KoafIzvlechGazEconomicMin {get; set;}
        public float KoafIzvlechGazEconomicMax {get; set;}
        public float KoafIzvlechCondEconomicMin {get; set;}
        public float KoafIzvlechCondEconomicMax {get; set;}
        public float davlplastinitialmin {get; set;}
        public float davlplastinitialmax {get; set;}
        public float GasFactorInitialmin {get; set;}
        public float GasFactorInitialmax {get; set;}
        public float GasFactorCurrentmin {get; set;}
        public float GasFactorCurrentmax {get; set;}
        public float densitygasmin {get; set;}
        public float densitygasmax {get; set;}
        public float teplosposobmin {get; set;}
        public float teplosposobmax {get; set;}
        public float densitymin {get; set;}
        public float densitymax {get; set;}
        public float hydrocarbonmin {get; set;}
        public float hydrocarbonmax {get; set;}
        public float initialvalue {get; set;}
        public float currentvalue {get; set;}
        public float h2smin {get; set;}
        public float h2smax {get; set;}
        public float nitrogenmin {get; set;}
        public float nitrogenmax {get; set;}
        public float co2min {get; set;}
        public float co2max {get; set;}
        public float tempplastmin {get; set;}
        public float tempplastmax {get; set;}
        public float viscositymin {get; set;}
        public float viscositymax {get; set;}
        public float sulphurmin {get; set;}
        public float sulphurmax {get; set;}
        public float resinmin {get; set;}
        public float resinmax {get; set;}
        public float paraffinmin {get; set;}
        public float paraffinmax {get; set;}
        public float pourpointmin {get; set;}
        public float pourpointmax {get; set;}
        public float densitycondmin {get; set;}
        public float densitycondmax {get; set;}
        public float WaterCutting {get; set;}
        public float InitialValueMax {get; set;}
        public float CurrentValueMax {get; set;}
        public float MethaneMin {get; set;}
        public float MethaneMax {get; set;}
        public float OtherHCGasMin {get; set;}
        public float OtherHCGasMax {get; set;}
        public float HeatValueMin {get; set;}
        public float HeatValueMax {get; set;}
        public float EthaneMin {get; set;}
        public float EthaneMax {get; set;}
        public float PropaneMin {get; set;}
        public float PropaneMax {get; set;}
    }
}