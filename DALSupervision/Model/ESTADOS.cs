namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.ESTADOS")]
    public partial class ESTADOS
    {
        public ESTADOS()
        {
            CONTRATOS = new HashSet<CONTRATOS>();
            ESTCONTRATOS = new HashSet<ESTCONTRATOS>();
            ESTCONTRATOS1 = new HashSet<ESTCONTRATOS>();
            MOD_CONTRATOS = new HashSet<MOD_CONTRATOS>();
            ESTADOS1 = new HashSet<ESTADOS>();
            ESTADOS2 = new HashSet<ESTADOS>();
        }

        [Key]
        [StringLength(3)]
        public string COD_EST { get; set; }

        [StringLength(30)]
        public string NOM_EST { get; set; }

        [StringLength(2)]
        public string TIP_EST { get; set; }

        [StringLength(3)]
        public string SIGLA { get; set; }

        [StringLength(20)]
        public string ESTADO { get; set; }

        public virtual ICollection<CONTRATOS> CONTRATOS { get; set; }

        public virtual ICollection<ESTCONTRATOS> ESTCONTRATOS { get; set; }

        public virtual ICollection<ESTCONTRATOS> ESTCONTRATOS1 { get; set; }

        public virtual ICollection<MOD_CONTRATOS> MOD_CONTRATOS { get; set; }

        public virtual ICollection<ESTADOS> ESTADOS1 { get; set; }

        public virtual ICollection<ESTADOS> ESTADOS2 { get; set; }
    }
}
