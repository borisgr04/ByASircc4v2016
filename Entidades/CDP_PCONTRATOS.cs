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
    public partial class CDP_PCONTRATOS
    {
        public int NRO_CDP { get; set; }
        public string NUM_PCON { get; set; }
        public System.DateTime FEC_CDP { get; set; }
        public Nullable<decimal> VAL_CDP { get; set; }
    
        public virtual PCONTRATOS PCONTRATOS { get; set; }
    }
    
}
