namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.RP_CONTRATOS")]
    public partial class RP_CONTRATOS
    {
        public RP_CONTRATOS()
        {
            RUBROS_CONTRATOS = new HashSet<RUBROS_CONTRATOS>();
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string NRO_RP { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string COD_CON { get; set; }

        public DateTime FEC_RP { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short VIGENCIA { get; set; }

        [StringLength(20)]
        public string DOC_SOP { get; set; }

        public decimal? VAL_RP { get; set; }

        public decimal? VAL_PAGO { get; set; }

        [StringLength(20)]
        public string USAP { get; set; }

        public DateTime? FEC_REG { get; set; }

        [StringLength(20)]
        public string USBD { get; set; }

        [StringLength(10)]
        public string NRO_CDP { get; set; }

        public virtual CDP_CONTRATOS CDP_CONTRATOS { get; set; }

        public virtual ICollection<RUBROS_CONTRATOS> RUBROS_CONTRATOS { get; set; }
    }
}
