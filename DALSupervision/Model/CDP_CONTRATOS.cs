namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.CDP_CONTRATOS")]
    public partial class CDP_CONTRATOS
    {
        public CDP_CONTRATOS()
        {
            C_RUBROS_CDP = new HashSet<C_RUBROS_CDP>();
            RP_CONTRATOS = new HashSet<RP_CONTRATOS>();
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string NRO_CDP { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string COD_CON { get; set; }

        public DateTime FEC_CDP { get; set; }

        public decimal? VAL_CDP { get; set; }

        [StringLength(2)]
        public string VIG_FUT { get; set; }

        public virtual ICollection<C_RUBROS_CDP> C_RUBROS_CDP { get; set; }

        public virtual CONTRATOS CONTRATOS { get; set; }

        public virtual ICollection<RP_CONTRATOS> RP_CONTRATOS { get; set; }
    }
}
