namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.PCONMUN")]
    public partial class PCONMUN
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(5)]
        public string COD_MUN { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string NRO_PCON { get; set; }

        public int? GRUPO { get; set; }

        public virtual PCONTRATOS PCONTRATOS { get; set; }
    }
}
