namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.EP_CLAUSULAS")]
    public partial class EP_CLAUSULAS
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

        public decimal? IDE_PMIN { get; set; }

        [StringLength(2)]
        public string TIP_PAR { get; set; }

        [StringLength(1)]
        public string IS_ENTER_FINAL { get; set; }

        public byte? ORDEN { get; set; }

        public decimal? ID_EP { get; set; }

        public string CLA_TEXTO { get; set; }

        public string CLA_CRUZADA { get; set; }

        public virtual ESTPREV ESTPREV { get; set; }
    }
}
