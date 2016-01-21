namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.ESTCONTRATOS")]
    public partial class ESTCONTRATOS
    {
        public ESTCONTRATOS()
        {
            INT_CONTROL_DOC1 = new HashSet<INT_CONTROL_DOC>();
            INT_DETCUENTA = new HashSet<INT_DETCUENTA>();
            INT_INFOCONT = new HashSet<INT_INFOCONT>();
        }

        [Required]
        [StringLength(15)]
        public string COD_CON { get; set; }

        [Required]
        [StringLength(3)]
        public string EST_INI { get; set; }

        [Required]
        [StringLength(3)]
        public string EST_FIN { get; set; }

        public DateTime FEC_ENT { get; set; }

        [StringLength(100)]
        public string DOC_ACT { get; set; }

        [Required]
        [StringLength(15)]
        public string USUARIO { get; set; }

        public DateTime FEC_REG { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(500)]
        public string OBS_EST { get; set; }

        public decimal? VAL_PAGO { get; set; }

        [StringLength(2)]
        public string ESTADO { get; set; }

        public int? NVISITAS { get; set; }

        public int? NRO_DOC { get; set; }

        public decimal? POR_EJE_FIS { get; set; }

        public DateTime? FEC_FIN { get; set; }

        public DateTime? FEC_PINI { get; set; }

        public int? NVIS_PER { get; set; }

        public decimal? POR_EJE_FIS_PER { get; set; }

        public decimal? SALDO_PER { get; set; }

        public DateTime? FEC_ACT { get; set; }

        public decimal? SAL_ANT { get; set; }

        [StringLength(2)]
        public string CLA_DOC { get; set; }

        [StringLength(2)]
        public string EST_DOC { get; set; }

        public decimal? ID_CTRDOC { get; set; }

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
