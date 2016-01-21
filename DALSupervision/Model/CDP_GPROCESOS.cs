namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.CDP_GPROCESOS")]
    public partial class CDP_GPROCESOS
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NRO_CDP { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string NUM_GPROC { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime FEC_CDP { get; set; }

        public decimal? VAL_CDP { get; set; }

        public int? GRUPO { get; set; }

        public virtual GPROCESOS GPROCESOS { get; set; }
    }
}
