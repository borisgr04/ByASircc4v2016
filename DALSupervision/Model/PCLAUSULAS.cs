namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.PCLAUSULAS")]
    public partial class PCLAUSULAS
    {
        public decimal ID { get; set; }

        public decimal? ID_PLA { get; set; }

        [StringLength(4)]
        public string TIP_PLA { get; set; }

        [StringLength(200)]
        public string CLA_TIT { get; set; }

        public decimal? CLA_NUM { get; set; }

        [StringLength(200)]
        public string CLA_CAM { get; set; }

        [StringLength(200)]
        public string CLA_PAR { get; set; }

        [StringLength(4000)]
        public string CLA_TEXTO { get; set; }

        [StringLength(20)]
        public string NUM_PRO { get; set; }

        public decimal? IDE_PMIN { get; set; }

        [StringLength(2)]
        public string TIP_PAR { get; set; }

        [StringLength(1)]
        public string IS_ENTER_FINAL { get; set; }

        public byte? ORDEN { get; set; }

        public string CLA_CRUZADA { get; set; }
    }
}
