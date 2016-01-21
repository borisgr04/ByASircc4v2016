namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.MOD_CON_POLIZAS")]
    public partial class MOD_CON_POLIZAS
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(15)]
        public string NUM_SOL_ADI { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal COD_POL { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(15)]
        public string COD_CON { get; set; }

        public decimal? POR_SMMLV { get; set; }

        [StringLength(3)]
        public string CAL_APARTIRDE { get; set; }

        public decimal? VIGENCIA { get; set; }

        [StringLength(5)]
        public string APARTIRDE { get; set; }

        [StringLength(10)]
        public string TIPO { get; set; }

        public DateTime? FEC_REG { get; set; }

        [StringLength(20)]
        public string USBD { get; set; }

        [StringLength(20)]
        public string USAP { get; set; }
    }
}
