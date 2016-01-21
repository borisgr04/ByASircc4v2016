namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.IMP_CONTRATOS")]
    public partial class IMP_CONTRATOS
    {
        [Required]
        [StringLength(10)]
        public string COD_CON { get; set; }

        [Required]
        [StringLength(10)]
        public string NRO_IMP { get; set; }

        [Required]
        [StringLength(4000)]
        public string NRO_COM { get; set; }

        public short? VIG_LIQ { get; set; }

        public long? VAL_IMP { get; set; }

        [StringLength(20)]
        public string COD_SOP { get; set; }

        public DateTime? FEC_REG { get; set; }

        [StringLength(20)]
        public string USER_REG { get; set; }

        public decimal ID { get; set; }

        public virtual IMPUESTOS IMPUESTOS { get; set; }
    }
}
