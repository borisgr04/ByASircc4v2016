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
    
    public partial class EP_POLIZAS2
    {
        public decimal ID { get; set; }
        public Nullable<int> COD_POL { get; set; }
        public string DES_POL { get; set; }
        public string PLA_POL { get; set; }
        public string VAL_POL { get; set; }
        public Nullable<int> GRUPO { get; set; }
        public Nullable<decimal> ID_EP { get; set; }
    
        public virtual ESTPREV ESTPREV { get; set; }
        public virtual POLIZAS POLIZAS { get; set; }
    }
}
