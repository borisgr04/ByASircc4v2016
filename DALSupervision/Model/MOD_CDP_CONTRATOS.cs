namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.MOD_CDP_CONTRATOS")]
    public partial class MOD_CDP_CONTRATOS
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(15)]
        public string NUM_SOL_ADI { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string NRO_CDP { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(15)]
        public string COD_CON { get; set; }

        public DateTime FEC_CDP { get; set; }

        public decimal? VAL_CDP { get; set; }

        public DateTime? FEC_REG { get; set; }

        [StringLength(20)]
        public string USBD { get; set; }

        [StringLength(20)]
        public string USAP { get; set; }

        public virtual SOL_ADICIONES SOL_ADICIONES { get; set; }
    }
}
