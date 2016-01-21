namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.GD_CT_OFICIOS")]
    public partial class GD_CT_OFICIOS
    {
        public DateTime? FEC_OFI { get; set; }

        [StringLength(10)]
        public string COD_CON { get; set; }

        [StringLength(2)]
        public string TIP_OFI { get; set; }

        [StringLength(2)]
        public string EST_OFI { get; set; }

        public decimal ID { get; set; }
    }
}
