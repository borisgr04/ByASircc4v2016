//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class RUBROS_CONTRATOS
    {
        public string COD_RUB { get; set; }
        public string COD_CON { get; set; }
        public string NOM_RUB { get; set; }
        public Nullable<decimal> VAL_COMPROMISO { get; set; }
        public string NRO_RP { get; set; }
        public Nullable<System.DateTime> FEC_REG { get; set; }
        public string USBD { get; set; }
        public Nullable<short> VIGENCIA { get; set; }
        public decimal ID { get; set; }
    
        public virtual RP_CONTRATOS RP_CONTRATOS { get; set; }
    }
}
