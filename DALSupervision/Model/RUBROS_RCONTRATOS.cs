namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.RUBROS_RCONTRATOS")]
    public partial class RUBROS_RCONTRATOS
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(15)]
        public string COD_CON { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string COD_RUB { get; set; }

        public decimal? VALOR { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string NRO_CDP { get; set; }

        [StringLength(4)]
        public string VIGENCIA_CDP { get; set; }
    }
}
