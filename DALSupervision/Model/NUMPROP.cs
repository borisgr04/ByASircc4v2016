namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.NUMPROP")]
    public partial class NUMPROP
    {
        [Key]
        [StringLength(2)]
        public string TIP_PROP { get; set; }

        public decimal? NUM_INI { get; set; }

        public decimal? NUM_ACT { get; set; }
    }
}
