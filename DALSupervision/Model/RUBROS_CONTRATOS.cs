namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.RUBROS_CONTRATOS")]
    public partial class RUBROS_CONTRATOS
    {
        [Required]
        [StringLength(50)]
        public string COD_RUB { get; set; }

        [Required]
        [StringLength(10)]
        public string COD_CON { get; set; }

        [StringLength(400)]
        public string NOM_RUB { get; set; }

        public decimal? VAL_COMPROMISO { get; set; }

        [StringLength(20)]
        public string NRO_RP { get; set; }

        public DateTime? FEC_REG { get; set; }

        [StringLength(20)]
        public string USBD { get; set; }

        public short? VIGENCIA { get; set; }

        public decimal ID { get; set; }

        public virtual RP_CONTRATOS RP_CONTRATOS { get; set; }
    }
}
