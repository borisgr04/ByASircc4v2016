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
    public partial class ESTCONTRATOS
    {
        public ESTCONTRATOS()
        {
            this.INT_CONTROL_DOC1 = new HashSet<INT_CONTROL_DOC>();
            this.INT_DETCUENTA = new HashSet<INT_DETCUENTA>();
            this.INT_INFOCONT = new HashSet<INT_INFOCONT>();
        }
    
        public string COD_CON { get; set; }
        public string EST_INI { get; set; }
        public string EST_FIN { get; set; }
        public System.DateTime FEC_ENT { get; set; }
        public string DOC_ACT { get; set; }
        public string USUARIO { get; set; }
        public System.DateTime FEC_REG { get; set; }
        public int ID { get; set; }
        public string OBS_EST { get; set; }
        public Nullable<decimal> VAL_PAGO { get; set; }
        public string ESTADO { get; set; }
        public Nullable<int> NVISITAS { get; set; }
        public Nullable<int> NRO_DOC { get; set; }
        public Nullable<decimal> POR_EJE_FIS { get; set; }
        public Nullable<System.DateTime> FEC_FIN { get; set; }
        public Nullable<System.DateTime> FEC_PINI { get; set; }
        public Nullable<int> NVIS_PER { get; set; }
        public Nullable<decimal> POR_EJE_FIS_PER { get; set; }
        public Nullable<decimal> SALDO_PER { get; set; }
        public Nullable<System.DateTime> FEC_ACT { get; set; }
        public Nullable<decimal> SAL_ANT { get; set; }
        public string CLA_DOC { get; set; }
        public string EST_DOC { get; set; }
        public Nullable<decimal> ID_CTRDOC { get; set; }
    
        public virtual ACTAPARCIAL ACTAPARCIAL { get; set; }
        public virtual CONTRATOS CONTRATOS { get; set; }
        public virtual ESTADOS ESTADOS { get; set; }
        public virtual ESTADOS ESTADOS1 { get; set; }
        public virtual INT_CONTROL_DOC INT_CONTROL_DOC { get; set; }
        public virtual ICollection<INT_CONTROL_DOC> INT_CONTROL_DOC1 { get; set; }
        public virtual ICollection<INT_DETCUENTA> INT_DETCUENTA { get; set; }
        public virtual ICollection<INT_INFOCONT> INT_INFOCONT { get; set; }
    }
    
}