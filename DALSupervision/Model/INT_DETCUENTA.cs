namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.INT_DETCUENTA")]
    public partial class INT_DETCUENTA
    {
        public decimal ID { get; set; }

        public int IDACTA { get; set; }

        [StringLength(10)]
        public string NRO_RP { get; set; }

        [StringLength(10)]
        public string NRO_OP { get; set; }

        public decimal? VAL_OP { get; set; }

        public DateTime? FEC_OP { get; set; }

        public DateTime? FEC_CAU { get; set; }

        [StringLength(10)]
        public string NRO_EGR { get; set; }

        public DateTime? FEC_EGR { get; set; }

        [StringLength(1)]
        public string EST_EGR { get; set; }

        public short? VIG_RP { get; set; }

        public decimal? ID_CTRDOC { get; set; }

        public DateTime? FEC_REG { get; set; }

        public DateTime? FEC_MOD { get; set; }

        [StringLength(20)]
        public string USAP { get; set; }

        [StringLength(20)]
        public string USAPM { get; set; }

        public virtual ESTCONTRATOS ESTCONTRATOS { get; set; }

        public virtual INT_CONTROL_DOC INT_CONTROL_DOC { get; set; }
    }
}
