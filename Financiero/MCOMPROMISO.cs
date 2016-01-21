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

namespace Financiero
{
    public partial class MCOMPROMISO
    {
        public MCOMPROMISO()
        {
            this.DCOMPROMISO = new HashSet<DCOMPROMISO>();
            this.MORDEN = new HashSet<MORDEN>();
        }
    
        public decimal VIGENCIA { get; set; }
        public decimal NUM_COMPROMISO { get; set; }
        public System.DateTime FEC_COMPROMISO { get; set; }
        public string OBJ_COMPROMISO { get; set; }
        public decimal NUM_CERTIFICADO { get; set; }
        public decimal TIPO_COMPROMISO { get; set; }
        public string NRO_DOCUMENTO { get; set; }
        public decimal CLASE_DOCUMENTO { get; set; }
        public System.DateTime FEC_DOCUMENTO { get; set; }
        public Nullable<System.DateTime> FEC_VENCE_DOCUMENTO { get; set; }
        public string FORMALIDADES_PLENAS { get; set; }
        public string NIT { get; set; }
        public string COD_CENTRO { get; set; }
        public string COD_REGION { get; set; }
        public decimal ESTADO { get; set; }
        public Nullable<System.DateTime> FEC_ANULADO { get; set; }
        public string CONTRIBUCION { get; set; }
        public Nullable<decimal> RP_CONTRIBUCION { get; set; }
        public string CASTIGO { get; set; }
        public Nullable<decimal> NUM_COMPROMISO_VA { get; set; }
        public string COD_DEPTO { get; set; }
        public string COD_MUNIC { get; set; }
        public decimal VALOR_CAMBIO { get; set; }
    
        public virtual ICollection<DCOMPROMISO> DCOMPROMISO { get; set; }
        public virtual MRESERVA MRESERVA { get; set; }
        public virtual ICollection<MORDEN> MORDEN { get; set; }
    }
    
}