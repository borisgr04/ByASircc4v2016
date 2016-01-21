namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.DOC_PLANTILLA")]
    public partial class DOC_PLANTILLA
    {
        public DOC_PLANTILLA()
        {
            DOC_SECCIONES = new HashSet<DOC_SECCIONES>();
        }

        public decimal ID { get; set; }

        [StringLength(20)]
        public string NRO_DOC { get; set; }

        [StringLength(2)]
        public string COD_TIP { get; set; }

        [StringLength(200)]
        public string TITULO { get; set; }

        public DateTime? FEC_REV { get; set; }

        [StringLength(20)]
        public string NRO_REV { get; set; }

        [StringLength(2)]
        public string EST_DOC { get; set; }

        public DateTime? FEC_DOC { get; set; }

        [StringLength(20)]
        public string NUM_PROC { get; set; }

        public decimal? ID_PLA { get; set; }

        [StringLength(3)]
        public string EST_COMPLETADO { get; set; }

        public virtual PL_TIPOS_PLANTILLA PL_TIPOS_PLANTILLA { get; set; }

        public virtual PCONTRATOS PCONTRATOS { get; set; }

        public virtual ICollection<DOC_SECCIONES> DOC_SECCIONES { get; set; }

        public virtual PL_PLANTILLA PL_PLANTILLA { get; set; }
    }
}
