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
    public partial class CAL_VIG_POL
    {
        public CAL_VIG_POL()
        {
            this.EP_POLIZAS = new HashSet<EP_POLIZAS>();
            this.PPOLIZAS = new HashSet<PPOLIZAS>();
        }
    
        public string COD_CAL { get; set; }
        public string DESCRIPCION { get; set; }
    
        public virtual ICollection<EP_POLIZAS> EP_POLIZAS { get; set; }
        public virtual ICollection<PPOLIZAS> PPOLIZAS { get; set; }
    }
    
}
