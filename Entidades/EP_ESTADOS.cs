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
    public partial class EP_ESTADOS
    {
        public EP_ESTADOS()
        {
            this.ESTPREV = new HashSet<ESTPREV>();
        }
    
        public string COD_EST { get; set; }
        public string NOM_EST { get; set; }
    
        public virtual ICollection<ESTPREV> ESTPREV { get; set; }
    }
    
}