namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.RUBROS_PCONTRATOS")]
    public partial class RUBROS_PCONTRATOS
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string COD_RUB { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string NUM_PRO { get; set; }

        public decimal? VALOR { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string NRO_CDP { get; set; }

        [StringLength(4)]
        public string VIGENCIA_CDP { get; set; }

        public virtual PCONTRATOS PCONTRATOS { get; set; }
    }
}
