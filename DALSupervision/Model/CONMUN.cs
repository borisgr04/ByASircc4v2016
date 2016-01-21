namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.CONMUN")]
    public partial class CONMUN
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(5)]
        public string COD_MUN { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string NRO_CON { get; set; }
    }
}
