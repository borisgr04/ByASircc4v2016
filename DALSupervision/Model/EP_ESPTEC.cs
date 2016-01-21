namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.EP_ESPTEC")]
    public partial class EP_ESPTEC
    {
        [StringLength(300)]
        public string DESC_ITEM { get; set; }

        public decimal? CANT_ITEM { get; set; }

        [StringLength(2)]
        public string UNI_ITEM { get; set; }

        public decimal? VAL_UNI_ITEM { get; set; }

        public decimal? PORC_IVA { get; set; }

        public decimal ID { get; set; }

        [StringLength(12)]
        public string USAP_REG { get; set; }

        public DateTime? FEC_REG { get; set; }

        [StringLength(12)]
        public string USAP_MOD { get; set; }

        public DateTime? FEC_MOD { get; set; }

        public decimal? ID_EP { get; set; }

        public byte? GRUPO { get; set; }

        public virtual EP_DT_UNIDADES EP_DT_UNIDADES { get; set; }

        public virtual ESTPREV ESTPREV { get; set; }
    }
}
