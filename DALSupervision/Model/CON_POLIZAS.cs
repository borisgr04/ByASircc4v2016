namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.CON_POLIZAS")]
    public partial class CON_POLIZAS
    {
        [Key]
        [Column(Order = 0)]
        public decimal COD_POL { get; set; }

        [Key]
        [Column(Order = 1)]
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
    }
}
