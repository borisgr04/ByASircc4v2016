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
    
    public partial class HDEP_ABOGADOS
    {
        public string COD_DEP { get; set; }
        public string IDE_TER { get; set; }
        public Nullable<System.DateTime> FEC_ASIGNACION { get; set; }
        public Nullable<System.DateTime> FEC_RETIRO { get; set; }
        public string USAP { get; set; }
        public string USBD { get; set; }
        public string USAP_RETIRO { get; set; }
        public string ESTADO { get; set; }
        public decimal ID_HDEP { get; set; }
        public string ASIG_PROC { get; set; }
        public string COORDINADOR { get; set; }
    
        public virtual DEPENDENCIA DEPENDENCIA { get; set; }
        public virtual TERCEROS TERCEROS { get; set; }
    }
}
