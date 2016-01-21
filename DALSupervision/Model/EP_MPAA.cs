namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.EP_MPAA")]
    public partial class EP_MPAA
    {
        public EP_MPAA()
        {
            EP_PAA = new HashSet<EP_PAA>();
        }

        public decimal ID { get; set; }

        public short? VIGENCIA { get; set; }

        [StringLength(300)]
        public string OBSERV { get; set; }

        public DateTime? FEC_INI { get; set; }

        public DateTime? FEC_FIN { get; set; }

        [StringLength(2)]
        public string ESTADO { get; set; }

        [StringLength(20)]
        public string COD_SECOP { get; set; }

        public virtual ICollection<EP_PAA> EP_PAA { get; set; }
    }
}
