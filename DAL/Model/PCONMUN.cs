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
    
    public partial class PCONMUN
    {
        public string COD_MUN { get; set; }
        public string NRO_PCON { get; set; }
        public Nullable<int> GRUPO { get; set; }
    
        public virtual PCONTRATOS PCONTRATOS { get; set; }
    }
}
