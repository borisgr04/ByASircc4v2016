namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.PPOLIZAS")]
    public partial class PPOLIZAS
    {
        [Key]
        [Column(Order = 0)]
        public decimal COD_POL { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string NUM_PROC { get; set; }

        public decimal? POR_SMMLV { get; set; }

        [StringLength(3)]
        public string CAL_APARTIRDE { get; set; }

        public decimal? VIGENCIA { get; set; }

        [StringLength(5)]
        public string APARTIRDE { get; set; }

        [StringLength(1000)]
        public string CUBRIMIENTO { get; set; }

        public virtual CAL_VIG_POL CAL_VIG_POL { get; set; }

        public virtual CALCULOPOL CALCULOPOL { get; set; }

        public virtual PCONTRATOS PCONTRATOS { get; set; }
    }
}
