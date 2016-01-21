namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.PL_PLANTILLA")]
    public partial class PL_PLANTILLA
    {
        public PL_PLANTILLA()
        {
            DOC_PLANTILLA = new HashSet<DOC_PLANTILLA>();
            PL_SECCIONES = new HashSet<PL_SECCIONES>();
        }

        public decimal ID { get; set; }

        [StringLength(2)]
        public string COD_TIP { get; set; }

        [StringLength(200)]
        public string TITULO { get; set; }

        public DateTime? FEC_REV { get; set; }

        [StringLength(20)]
        public string NRO_REV { get; set; }

        [StringLength(2)]
        public string EST_PLA { get; set; }

        public decimal? DOC_MAX { get; set; }

        public virtual ICollection<DOC_PLANTILLA> DOC_PLANTILLA { get; set; }

        public virtual PL_TIPOS_PLANTILLA PL_TIPOS_PLANTILLA { get; set; }

        public virtual ICollection<PL_SECCIONES> PL_SECCIONES { get; set; }
    }
}
