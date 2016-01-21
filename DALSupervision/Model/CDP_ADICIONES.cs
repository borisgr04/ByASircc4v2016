namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.CDP_ADICIONES")]
    public partial class CDP_ADICIONES
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string NRO_CDP { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string NRO_ADI { get; set; }

        public DateTime FEC_CDP { get; set; }
    }
}
