namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.RUBROS_ADICIONES")]
    public partial class RUBROS_ADICIONES
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(30)]
        public string COD_RUB { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string NRO_ADI { get; set; }

        [StringLength(50)]
        public string NOM_RUB { get; set; }

        public decimal? VAL_COMPROMISO { get; set; }
    }
}
