namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.INT_CONTROL_DOC")]
    public partial class INT_CONTROL_DOC
    {
        public INT_CONTROL_DOC()
        {
            ESTCONTRATOS = new HashSet<ESTCONTRATOS>();
            INT_CONTROL_DOC1 = new HashSet<INT_CONTROL_DOC>();
            INT_DETTRASLADO = new HashSet<INT_DETTRASLADO>();
            INT_DETTRASLADO1 = new HashSet<INT_DETTRASLADO>();
            INT_DETCUENTA = new HashSet<INT_DETCUENTA>();
        }

        public decimal ID { get; set; }

        public int? IDACTA { get; set; }

        public DateTime? FEC_REC { get; set; }

        public DateTime? FEC_REC_SIS { get; set; }

        [StringLength(100)]
        public string OBS_REC { get; set; }

        [StringLength(2)]
        public string EST_DOC { get; set; }

        [StringLength(2)]
        public string ETA_DOC { get; set; }

        public DateTime? FEC_REV { get; set; }

        [StringLength(500)]
        public string OBS_REV { get; set; }

        [StringLength(20)]
        public string USAP_REC { get; set; }

        [StringLength(20)]
        public string USAP_REV { get; set; }

        [StringLength(20)]
        public string USAP_MOD { get; set; }

        public DateTime? FEC_MOD { get; set; }

        public DateTime? FEC_REV_SIS { get; set; }

        public decimal? IDPADRE { get; set; }

        [StringLength(2)]
        public string EST_REG { get; set; }

        public virtual ICollection<ESTCONTRATOS> ESTCONTRATOS { get; set; }

        public virtual ESTCONTRATOS ESTCONTRATOS1 { get; set; }

        public virtual ICollection<INT_CONTROL_DOC> INT_CONTROL_DOC1 { get; set; }

        public virtual INT_CONTROL_DOC INT_CONTROL_DOC2 { get; set; }

        public virtual ICollection<INT_DETTRASLADO> INT_DETTRASLADO { get; set; }

        public virtual ICollection<INT_DETTRASLADO> INT_DETTRASLADO1 { get; set; }

        public virtual ICollection<INT_DETCUENTA> INT_DETCUENTA { get; set; }
    }
}
