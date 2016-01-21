namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.EP_HESTADOEP")]
    public partial class EP_HESTADOEP
    {
        public EP_HESTADOEP()
        {
            ESTPREV = new HashSet<ESTPREV>();
            ESTPREV1 = new HashSet<ESTPREV>();
        }

        public decimal ID { get; set; }

        public decimal? ID_EP { get; set; }

        public DateTime? FEC_EP { get; set; }

        public DateTime? FSIS_EP { get; set; }

        [StringLength(20)]
        public string USAP_EP { get; set; }

        [StringLength(200)]
        public string OBS_EP { get; set; }

        [StringLength(2)]
        public string TIP_EP { get; set; }

        [StringLength(2)]
        public string EST_EP { get; set; }

        public virtual ICollection<ESTPREV> ESTPREV { get; set; }

        public virtual ICollection<ESTPREV> ESTPREV1 { get; set; }
    }
}
