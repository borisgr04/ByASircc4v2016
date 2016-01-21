namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.EP_CODIGOSUNSPSC")]
    public partial class EP_CODIGOSUNSPSC
    {
        public EP_CODIGOSUNSPSC()
        {
            EP_CODIGOSUNSPSC1 = new HashSet<EP_CODIGOSUNSPSC>();
            EP_PAA_UNSPSC = new HashSet<EP_PAA_UNSPSC>();
            EP_UNSPSC = new HashSet<EP_UNSPSC>();
        }

        [Key]
        [StringLength(8)]
        public string UNSPSC { get; set; }

        [StringLength(8)]
        public string CODIGO { get; set; }

        [StringLength(300)]
        public string NOMBRE { get; set; }

        [StringLength(1)]
        public string CLASIFICADOR { get; set; }

        [StringLength(8)]
        public string PADRE { get; set; }

        public virtual ICollection<EP_CODIGOSUNSPSC> EP_CODIGOSUNSPSC1 { get; set; }

        public virtual EP_CODIGOSUNSPSC EP_CODIGOSUNSPSC2 { get; set; }

        public virtual ICollection<EP_PAA_UNSPSC> EP_PAA_UNSPSC { get; set; }

        public virtual ICollection<EP_UNSPSC> EP_UNSPSC { get; set; }
    }
}
