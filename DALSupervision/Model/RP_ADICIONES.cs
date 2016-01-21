namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.RP_ADICIONES")]
    public partial class RP_ADICIONES
    {
        [Key]
        [StringLength(10)]
        public string NRO_RP { get; set; }

        [StringLength(10)]
        public string NRO_ADI { get; set; }

        public DateTime FEC_RP { get; set; }
    }
}
