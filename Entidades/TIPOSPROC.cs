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
    public partial class TIPOSPROC
    {
        public TIPOSPROC()
        {
            this.CONS_PROC = new HashSet<CONS_PROC>();
            this.ESTPREV = new HashSet<ESTPREV>();
            this.GPROCESOS = new HashSet<GPROCESOS>();
            this.MOD_TIP_PLA = new HashSet<MOD_TIP_PLA>();
            this.PACTIVIDADES = new HashSet<PACTIVIDADES>();
            this.PCONTRATOS = new HashSet<PCONTRATOS>();
            this.PSOLICITUDES = new HashSet<PSOLICITUDES>();
        }
    
        public string COD_TPROC { get; set; }
        public string NOM_TPROC { get; set; }
        public string ABRE_TPROC { get; set; }
        public string ESTA_TPROC { get; set; }
        public string COD_CTR { get; set; }
        public string CTR_F20_1A { get; set; }
    
        public virtual ICollection<CONS_PROC> CONS_PROC { get; set; }
        public virtual ICollection<ESTPREV> ESTPREV { get; set; }
        public virtual ICollection<GPROCESOS> GPROCESOS { get; set; }
        public virtual ICollection<MOD_TIP_PLA> MOD_TIP_PLA { get; set; }
        public virtual ICollection<PACTIVIDADES> PACTIVIDADES { get; set; }
        public virtual ICollection<PCONTRATOS> PCONTRATOS { get; set; }
        public virtual ICollection<PSOLICITUDES> PSOLICITUDES { get; set; }
    }
    
}
