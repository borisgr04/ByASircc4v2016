//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Entidades
{
    public partial class PPROPONENTESS
    {
        public PPROPONENTESS()
        {
            this.CONSORCIOSUTXC = new HashSet<CONSORCIOSUTXC>();
        }
    
        public decimal ID { get; set; }
        public string TIPO_PROP { get; set; }
        public string NUM_PROC { get; set; }
        public Nullable<System.DateTime> FEC_PROP { get; set; }
        public Nullable<decimal> VAL_PROP { get; set; }
        public Nullable<decimal> NUM_FOLIO { get; set; }
        public string IDE_PROP { get; set; }
        public string TIP_IDE_PROP { get; set; }
        public string EXP_IDE_PROP { get; set; }
        public string DV_PROP { get; set; }
        public string TIP_PER_PROP { get; set; }
        public string APE1_PROP { get; set; }
        public string APE2_PROP { get; set; }
        public string NOM1_PROP { get; set; }
        public string NOM2_PROP { get; set; }
        public string RAZ_SOC { get; set; }
        public string DIR_PROP { get; set; }
        public string TEL_PROP { get; set; }
        public string EMA_PROP { get; set; }
        public Nullable<System.DateTime> FEC_NAC { get; set; }
        public string ADJUDICADO { get; set; }
        public Nullable<System.DateTime> FEC_ADJUDICACION { get; set; }
        public string OBS_ADJUDICACION { get; set; }
        public string ESTADO { get; set; }
        public string COD_AUX { get; set; }
        public string ID_REP_LEGAL { get; set; }
        public string MUNICIPIO { get; set; }
        public Nullable<System.DateTime> FEC_REG { get; set; }
        public string USBD { get; set; }
        public string USAP { get; set; }
        public Nullable<System.DateTime> FEC_MOD { get; set; }
        public string USBD_MOD { get; set; }
        public string USAP_MOD { get; set; }
        public string APORTES { get; set; }
        public string NUMPOLIZA { get; set; }
        public Nullable<System.DateTime> FECHA_INICIAL { get; set; }
        public Nullable<System.DateTime> FECHA_FINAL { get; set; }
        public Nullable<int> ASEGURADORA { get; set; }
        public Nullable<int> NOM_POLIZA { get; set; }
        public Nullable<decimal> VALOR_POLIZA { get; set; }
        public string DENOMINACION { get; set; }
        public Nullable<decimal> VAL_SIN_IVA { get; set; }
    
        public virtual ASEGURADORAS ASEGURADORAS { get; set; }
        public virtual ICollection<CONSORCIOSUTXC> CONSORCIOSUTXC { get; set; }
        public virtual PCONTRATOS PCONTRATOS { get; set; }
        public virtual POLIZAS POLIZAS { get; set; }
        public virtual TIPPROPONENTE TIPPROPONENTE { get; set; }
        public virtual TERCEROS TERCEROS { get; set; }
        public virtual TERCEROS TERCEROS1 { get; set; }
    }
    
}
