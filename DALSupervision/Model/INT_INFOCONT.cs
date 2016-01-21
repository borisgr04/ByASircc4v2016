namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.INT_INFOCONT")]
    public partial class INT_INFOCONT
    {
        public INT_INFOCONT()
        {
            GD_DOC_ACTAS = new HashSet<GD_DOC_ACTAS>();
            INT_PAGOSST = new HashSet<INT_PAGOSST>();
        }

        [StringLength(10)]
        public string COD_CON { get; set; }

        public DateTime? FEC_INF { get; set; }

        public DateTime? FEC_INI { get; set; }

        public DateTime? FEC_FIN { get; set; }

        public decimal? CAN_HOJ { get; set; }

        public decimal? NUM_INF { get; set; }

        public DateTime? FE_REG { get; set; }

        [StringLength(10)]
        public string USAP { get; set; }

        [StringLength(20)]
        public string USBD { get; set; }

        [StringLength(2)]
        public string EST_INF { get; set; }

        [StringLength(4000)]
        public string DES_INF { get; set; }

        public decimal ID { get; set; }

        [StringLength(200)]
        public string NOT_INF { get; set; }

        public decimal? VAL_PAG { get; set; }

        [StringLength(2)]
        public string OBL_FAC { get; set; }

        [StringLength(200)]
        public string NOT2_INF { get; set; }

        public int? ID_ACTA { get; set; }

        [StringLength(2)]
        public string TIP_INF { get; set; }

        public virtual CONTRATOS CONTRATOS { get; set; }

        public virtual ESTCONTRATOS ESTCONTRATOS { get; set; }

        public virtual ICollection<GD_DOC_ACTAS> GD_DOC_ACTAS { get; set; }

        public virtual ICollection<INT_PAGOSST> INT_PAGOSST { get; set; }
    }
}
