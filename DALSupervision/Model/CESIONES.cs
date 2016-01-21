namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.CESIONES")]
    public partial class CESIONES
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(12)]
        public string NIT_ANT { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(12)]
        public string NIT_NUE { get; set; }

        public int? PLA_CES { get; set; }

        public int? VAL_CES { get; set; }

        public DateTime? FEC_CES { get; set; }

        [StringLength(20)]
        public string RES_AUT { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string COD_CON { get; set; }

        public DateTime? FEC_RES { get; set; }
    }
}
