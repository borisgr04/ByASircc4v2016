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
    public partial class RUBROS
    {
        public RUBROS()
        {
            this.C_RUBROS_CDP = new HashSet<C_RUBROS_CDP>();
            this.EP_RUBROS_CDP = new HashSet<EP_RUBROS_CDP>();
        }
    
        public string COD_RUB { get; set; }
        public string DES_RUB { get; set; }
        public short VIGENCIA { get; set; }
        public string COD_UNIDAD { get; set; }
        public string COD_RECURSO { get; set; }
        public string CLASE { get; set; }
    
        public virtual ICollection<C_RUBROS_CDP> C_RUBROS_CDP { get; set; }
        public virtual ICollection<EP_RUBROS_CDP> EP_RUBROS_CDP { get; set; }
    }
    
}