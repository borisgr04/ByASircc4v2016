namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.EP_FORMA_PAGO")]
    public partial class EP_FORMA_PAGO
    {
        public decimal ID { get; set; }

        public decimal? ID_EP { get; set; }

        public decimal? ORD_FPAG { get; set; }

        [StringLength(2)]
        public string TIP_FPAG { get; set; }

        public decimal? VAL_FPAG { get; set; }

        public decimal? POR_FPAG { get; set; }

        [StringLength(2000)]
        public string CON_FPAG { get; set; }

        [StringLength(1)]
        public string PGEN_FPAG { get; set; }

        public DateTime? FEC_REG { get; set; }

        [StringLength(12)]
        public string USAP_REG { get; set; }

        public DateTime? FEC_MOD { get; set; }

        [StringLength(12)]
        public string USAP_MOD { get; set; }

        public decimal? CAN_PAG { get; set; }

        public virtual ESTPREV ESTPREV { get; set; }

        public virtual TIPO_PAGO TIPO_PAGO { get; set; }
    }
}
