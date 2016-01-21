namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.EP_DT_CAP_JUR")]
    public partial class EP_DT_CAP_JUR
    {
        public EP_DT_CAP_JUR()
        {
            EP_CAP_JUR = new HashSet<EP_CAP_JUR>();
        }

        [StringLength(2)]
        public string EST_CAPJ { get; set; }

        [StringLength(400)]
        public string DES_CAPJ { get; set; }

        public decimal ID { get; set; }

        public virtual ICollection<EP_CAP_JUR> EP_CAP_JUR { get; set; }
    }
}
