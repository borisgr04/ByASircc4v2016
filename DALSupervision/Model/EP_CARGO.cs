namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.EP_CARGO")]
    public partial class EP_CARGO
    {
        [Key]
        [StringLength(2)]
        public string COD_CARGO { get; set; }

        [StringLength(100)]
        public string DES_CARGO { get; set; }

        [StringLength(4)]
        public string VIG_CARGO { get; set; }

        [StringLength(2)]
        public string EST_CARGO { get; set; }
    }
}
