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
    
    public partial class MUNICIPIOS
    {
        public MUNICIPIOS()
        {
            this.EP_CONMUN = new HashSet<EP_CONMUN>();
        }
    
        public string COD_MUN { get; set; }
        public string NOM_MUN { get; set; }
    
        public virtual ICollection<EP_CONMUN> EP_CONMUN { get; set; }
    }
}
