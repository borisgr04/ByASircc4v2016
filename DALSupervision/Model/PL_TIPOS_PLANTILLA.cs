namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.PL_TIPOS_PLANTILLA")]
    public partial class PL_TIPOS_PLANTILLA
    {
        public PL_TIPOS_PLANTILLA()
        {
            DOC_PLANTILLA = new HashSet<DOC_PLANTILLA>();
            MOD_TIP_PLA = new HashSet<MOD_TIP_PLA>();
            PACTIVIDADES = new HashSet<PACTIVIDADES>();
            PCRONOGRAMAS = new HashSet<PCRONOGRAMAS>();
            PL_PLANTILLA = new HashSet<PL_PLANTILLA>();
        }

        [Key]
        [StringLength(2)]
        public string COD_TIP { get; set; }

        [StringLength(200)]
        public string NOM_TIP { get; set; }

        public virtual ICollection<DOC_PLANTILLA> DOC_PLANTILLA { get; set; }

        public virtual ICollection<MOD_TIP_PLA> MOD_TIP_PLA { get; set; }

        public virtual ICollection<PACTIVIDADES> PACTIVIDADES { get; set; }

        public virtual ICollection<PCRONOGRAMAS> PCRONOGRAMAS { get; set; }

        public virtual ICollection<PL_PLANTILLA> PL_PLANTILLA { get; set; }
    }
}
