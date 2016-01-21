namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.GD_DOC_ACTAS")]
    public partial class GD_DOC_ACTAS
    {
        public decimal ID { get; set; }

        public decimal? ID_DOC { get; set; }

        [StringLength(10)]
        public string COD_CON { get; set; }

        public decimal? ID_INF { get; set; }

        public DateTime? FEC_REG { get; set; }

        [StringLength(20)]
        public string USAP { get; set; }

        [StringLength(2)]
        public string EST_REL { get; set; }

        [StringLength(2)]
        public string TIP_DOC { get; set; }

        public virtual CONTRATOS CONTRATOS { get; set; }

        public virtual INT_INFOCONT INT_INFOCONT { get; set; }

        public virtual TIP_DOC TIP_DOC1 { get; set; }
    }
}
