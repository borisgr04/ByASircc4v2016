namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.INT_PAGOSST")]
    public partial class INT_PAGOSST
    {
        [StringLength(10)]
        public string COD_CON { get; set; }

        [StringLength(2)]
        public string TIPO_PLA { get; set; }

        [StringLength(20)]
        public string PLANILLAN { get; set; }

        public decimal? VAL_SALUD { get; set; }

        public decimal? VAL_PENSION { get; set; }

        public decimal? VAL_RIESGOS { get; set; }

        public decimal? VAL_PARAF { get; set; }

        [StringLength(10)]
        public string MES_PAGO { get; set; }

        [StringLength(4)]
        public string YEAR_PAGO { get; set; }

        public decimal? NRO_DOC { get; set; }

        public decimal ID { get; set; }

        [StringLength(20)]
        public string USAP { get; set; }

        [StringLength(20)]
        public string USBD { get; set; }

        public DateTime? FEC_REG { get; set; }

        [StringLength(200)]
        public string OBS { get; set; }

        public DateTime? FEC_MOD { get; set; }

        [StringLength(20)]
        public string USBDM { get; set; }

        [StringLength(20)]
        public string USAPM { get; set; }

        [StringLength(2)]
        public string ESTADO { get; set; }

        public decimal? IDE_INF { get; set; }

        public virtual CONTRATOS CONTRATOS { get; set; }

        public virtual INT_INFOCONT INT_INFOCONT { get; set; }
    }
}
