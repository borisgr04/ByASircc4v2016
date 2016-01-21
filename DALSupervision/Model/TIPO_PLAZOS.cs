namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.TIPO_PLAZOS")]
    public partial class TIPO_PLAZOS
    {
        public TIPO_PLAZOS()
        {
            CONTRATOS = new HashSet<CONTRATOS>();
            ESTPREV = new HashSet<ESTPREV>();
            ESTPREV1 = new HashSet<ESTPREV>();
            MOD_CONTRATOS = new HashSet<MOD_CONTRATOS>();
        }

        [Key]
        [StringLength(1)]
        public string COD_TPLA { get; set; }

        [StringLength(50)]
        public string NOM_PLA { get; set; }

        public decimal? ORD_TPLA { get; set; }

        [StringLength(2)]
        public string EST_TPLA { get; set; }

        public virtual ICollection<CONTRATOS> CONTRATOS { get; set; }

        public virtual ICollection<ESTPREV> ESTPREV { get; set; }

        public virtual ICollection<ESTPREV> ESTPREV1 { get; set; }

        public virtual ICollection<MOD_CONTRATOS> MOD_CONTRATOS { get; set; }
    }
}
