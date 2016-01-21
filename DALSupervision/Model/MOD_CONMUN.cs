namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.MOD_CONMUN")]
    public partial class MOD_CONMUN
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(15)]
        public string NUM_SOL_ADI { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string COD_MUN { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(15)]
        public string NRO_CON { get; set; }
    }
}
