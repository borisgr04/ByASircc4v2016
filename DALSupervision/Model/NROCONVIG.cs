namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.NROCONVIG")]
    public partial class NROCONVIG
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short YEAR_VIG { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string COD_TIP { get; set; }

        public int? NRO_INI_CON { get; set; }

        public int? NRO_ACT_CON { get; set; }

        public decimal? POR_ADI_VIG { get; set; }

        public virtual TIPOSCONT TIPOSCONT { get; set; }
    }
}
