namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.GR_TIP_OFI")]
    public partial class GR_TIP_OFI
    {
        [Key]
        [StringLength(2)]
        public string TIP_OFI { get; set; }

        [StringLength(100)]
        public string NOM_OFI { get; set; }

        [StringLength(2)]
        public string ETA_OFI { get; set; }
    }
}
