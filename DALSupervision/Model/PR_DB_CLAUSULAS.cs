namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.PR_DB_CLAUSULAS")]
    public partial class PR_DB_CLAUSULAS
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

        [StringLength(2000)]
        public string CLA_TEXTO { get; set; }
    }
}
