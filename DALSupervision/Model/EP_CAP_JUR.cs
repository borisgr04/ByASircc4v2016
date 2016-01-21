namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.EP_CAP_JUR")]
    public partial class EP_CAP_JUR
    {
        public decimal ID { get; set; }

        public decimal? ID_EP { get; set; }

        public decimal? ID_CAPJ { get; set; }

        [StringLength(400)]
        public string DES_CAPJ { get; set; }

        public virtual EP_DT_CAP_JUR EP_DT_CAP_JUR { get; set; }

        public virtual ESTPREV ESTPREV { get; set; }
    }
}
