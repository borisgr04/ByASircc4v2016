namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.IMP_ADICIONES")]
    public partial class IMP_ADICIONES
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string NRO_ADI { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string NRO_IMP { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string NRO_COM { get; set; }
    }
}
