namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.GPPOLIZAS")]
    public partial class GPPOLIZAS
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

        [StringLength(10)]
        public string TIPO { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GRUPO { get; set; }

        public virtual GPROCESOS GPROCESOS { get; set; }
    }
}
