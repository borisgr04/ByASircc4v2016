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
    public partial class IMP_CONTRATOS
    {
        public string COD_CON { get; set; }
        public string NRO_IMP { get; set; }
        public string NRO_COM { get; set; }
        public Nullable<short> VIG_LIQ { get; set; }
        public Nullable<long> VAL_IMP { get; set; }
        public string COD_SOP { get; set; }
        public Nullable<System.DateTime> FEC_REG { get; set; }
        public string USER_REG { get; set; }
        public decimal ID { get; set; }
    
        public virtual IMPUESTOS IMPUESTOS { get; set; }
    }
    
}
