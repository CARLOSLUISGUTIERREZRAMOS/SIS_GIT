//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SIA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class VentasBoletos
    {
        public string Boleto { get; set; }
        public int Grupo { get; set; }
        public Nullable<int> Agente { get; set; }
        public Nullable<int> AgenteBol { get; set; }
        public Nullable<byte> TipoBoleto { get; set; }
        public string Cia { get; set; }
        public string Forma { get; set; }
        public Nullable<int> Serie { get; set; }
        public Nullable<byte> Validador { get; set; }
        public Nullable<byte> TipoPax { get; set; }
        public string Pasajero { get; set; }
        public Nullable<System.DateTime> FechaEmision { get; set; }
        public string Clase { get; set; }
        public string BaseTarifa { get; set; }
        public string Promocion { get; set; }
        public string TipoDoc { get; set; }
        public string NumDoc { get; set; }
        public string RutaRef { get; set; }
        public string CalculoTarifa { get; set; }
        public Nullable<decimal> TarifaRef { get; set; }
        public Nullable<decimal> Tarifa { get; set; }
        public Nullable<decimal> QSeguridad { get; set; }
        public Nullable<decimal> TotTarifa { get; set; }
        public Nullable<decimal> IgvTarifa { get; set; }
        public bool TaxExo { get; set; }
        public Nullable<decimal> PorcentajeComm { get; set; }
        public Nullable<decimal> Comision { get; set; }
        public Nullable<decimal> IgvComision { get; set; }
        public Nullable<decimal> OtrosIngresos { get; set; }
        public string TipoPago1 { get; set; }
        public string TipoPago2 { get; set; }
        public string TipoPago3 { get; set; }
        public string TipoPago4 { get; set; }
        public Nullable<decimal> Pago1 { get; set; }
        public Nullable<decimal> Pago2 { get; set; }
        public Nullable<decimal> Pago3 { get; set; }
        public Nullable<decimal> Pago4 { get; set; }
        public string Notas { get; set; }
        public string UsuarioReg { get; set; }
        public Nullable<System.DateTime> FechaReg { get; set; }
        public string UsuarioMod { get; set; }
        public Nullable<System.DateTime> FechaMod { get; set; }
        public string venta_tipo { get; set; }
        public string SysUser { get; set; }
        public string SysPc { get; set; }
        public Nullable<int> IdOtroIngreso { get; set; }
        public string pnr { get; set; }
        public Nullable<decimal> OtrosTax { get; set; }
        public string Conjuncion { get; set; }
        public Nullable<bool> Valorado { get; set; }
        public string rucnom { get; set; }
        public string ruc { get; set; }
        public Nullable<decimal> TotTax { get; set; }
        public Nullable<decimal> OtroImp { get; set; }
        public string Trans { get; set; }
        public string tour_code { get; set; }
        public Nullable<decimal> sup_rate { get; set; }
        public Nullable<decimal> sup_amt { get; set; }
        public string Reprice { get; set; }
        public Nullable<int> NumExchange { get; set; }
        public Nullable<decimal> ImpExchange { get; set; }
        public Nullable<decimal> DifExchange { get; set; }
        public string Moneda { get; set; }
        public Nullable<decimal> Bsr { get; set; }
        public Nullable<decimal> TarifaEqui { get; set; }
        public string Stat { get; set; }
        public string emd_razon { get; set; }
        public string emd_cod_emision { get; set; }
        public Nullable<decimal> emd_cupon_imp { get; set; }
        public string emd_cupon_moneda { get; set; }
        public string emd_boleto_num { get; set; }
        public Nullable<int> emd_boleto_cup { get; set; }
        public Nullable<int> emd_otros { get; set; }
        public string emd_airline { get; set; }
        public string emd_exc_over { get; set; }
        public Nullable<decimal> emd_exc_precio { get; set; }
        public Nullable<int> emd_exc_piezas { get; set; }
        public string emd_consume { get; set; }
        public string emd_notas { get; set; }
        public Nullable<int> emd_cupon_num { get; set; }
        public string emd_subcodigo { get; set; }
        public string OtrasNotas { get; set; }
        public string valorado_metodo { get; set; }
        public string moneda_fare { get; set; }
        public string tkt_ind { get; set; }
        public string sys_origen { get; set; }
        public string original_issue { get; set; }
        public string res_agent { get; set; }
        public string foid { get; set; }
        public Nullable<decimal> Total { get; set; }
        public string conj_ind { get; set; }
        public string Endosos { get; set; }
    
        public virtual VentasCabecera VentasCabecera { get; set; }
    }
}
