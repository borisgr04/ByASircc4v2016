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
    public partial class PL_SECCIONES
    {
        public decimal ID { get; set; }
        public Nullable<decimal> ID_PLA { get; set; }
        public string HTML { get; set; }
    
        public virtual PL_PLANTILLA PL_PLANTILLA { get; set; }
    }
    
}
