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
    public partial class IMPUESTOS
    {
        public IMPUESTOS()
        {
            this.IMP_CONTRATOS = new HashSet<IMP_CONTRATOS>();
        }
    
        public string NOM_IMP { get; set; }
        public Nullable<int> COD_PCT { get; set; }
        public string ESTADO { get; set; }
        public string NRO_IMP { get; set; }
    
        public virtual ICollection<IMP_CONTRATOS> IMP_CONTRATOS { get; set; }
    }
    
}