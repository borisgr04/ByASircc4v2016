namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.DEPENDENCIA")]
    public partial class DEPENDENCIA
    {
        public DEPENDENCIA()
        {
            CONS_PROC = new HashSet<CONS_PROC>();
            CONTRATOS = new HashSet<CONTRATOS>();
            CONTRATOS1 = new HashSet<CONTRATOS>();
            ESTPREV = new HashSet<ESTPREV>();
            ESTPREV1 = new HashSet<ESTPREV>();
            ESTPREV2 = new HashSet<ESTPREV>();
            PSOLICITUDES = new HashSet<PSOLICITUDES>();
            PSOLICITUDES1 = new HashSet<PSOLICITUDES>();
            HDEP_ABOGADOS = new HashSet<HDEP_ABOGADOS>();
            MOD_CONTRATOS = new HashSet<MOD_CONTRATOS>();
            MOD_CONTRATOS1 = new HashSet<MOD_CONTRATOS>();
            EP_PAA = new HashSet<EP_PAA>();
            PCONTRATOS = new HashSet<PCONTRATOS>();
            PCONTRATOS1 = new HashSet<PCONTRATOS>();
        }

        [Key]
        [StringLength(5)]
        public string COD_DEP { get; set; }

        [Required]
        [StringLength(50)]
        public string NOM_DEP { get; set; }

        [StringLength(1)]
        public string DEP_DEL { get; set; }

        [StringLength(3)]
        public string DEP_ABR { get; set; }

        [StringLength(12)]
        public string IDE_TER { get; set; }

        [StringLength(200)]
        public string NORMA_DEL { get; set; }

        [StringLength(2)]
        public string ESTADO { get; set; }

        [StringLength(100)]
        public string EMAIL { get; set; }

        [StringLength(30)]
        public string CARGO_ENC { get; set; }

        [StringLength(1)]
        public string INT_PRO { get; set; }

        public virtual ICollection<CONS_PROC> CONS_PROC { get; set; }

        public virtual ICollection<CONTRATOS> CONTRATOS { get; set; }

        public virtual ICollection<CONTRATOS> CONTRATOS1 { get; set; }

        public virtual ICollection<ESTPREV> ESTPREV { get; set; }

        public virtual ICollection<ESTPREV> ESTPREV1 { get; set; }

        public virtual ICollection<ESTPREV> ESTPREV2 { get; set; }

        public virtual ICollection<PSOLICITUDES> PSOLICITUDES { get; set; }

        public virtual ICollection<PSOLICITUDES> PSOLICITUDES1 { get; set; }

        public virtual ICollection<HDEP_ABOGADOS> HDEP_ABOGADOS { get; set; }

        public virtual ICollection<MOD_CONTRATOS> MOD_CONTRATOS { get; set; }

        public virtual ICollection<MOD_CONTRATOS> MOD_CONTRATOS1 { get; set; }

        public virtual ICollection<EP_PAA> EP_PAA { get; set; }

        public virtual ICollection<PCONTRATOS> PCONTRATOS { get; set; }

        public virtual ICollection<PCONTRATOS> PCONTRATOS1 { get; set; }
    }
}
