namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.CDP_PCONTRATOS")]
    public partial class CDP_PCONTRATOS
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NRO_CDP { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string NUM_PCON { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime FEC_CDP { get; set; }

        public decimal? VAL_CDP { get; set; }

        public virtual PCONTRATOS PCONTRATOS { get; set; }
    }
}
