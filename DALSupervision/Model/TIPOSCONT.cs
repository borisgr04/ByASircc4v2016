namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.TIPOSCONT")]
    public partial class TIPOSCONT
    {
        public TIPOSCONT()
        {
            CONTRATOS = new HashSet<CONTRATOS>();
            MOD_CONTRATOS = new HashSet<MOD_CONTRATOS>();
            NROCONVIG = new HashSet<NROCONVIG>();
            PSOLICITUDES = new HashSet<PSOLICITUDES>();
            SUBTIPOS = new HashSet<SUBTIPOS>();
        }

        [Key]
        [StringLength(5)]
        public string COD_TIP { get; set; }

        [Required]
        [StringLength(50)]
        public string NOM_TIP { get; set; }

        [StringLength(2)]
        public string EST_TIP { get; set; }

        public virtual ICollection<CONTRATOS> CONTRATOS { get; set; }

        public virtual ICollection<MOD_CONTRATOS> MOD_CONTRATOS { get; set; }

        public virtual ICollection<NROCONVIG> NROCONVIG { get; set; }

        public virtual ICollection<PSOLICITUDES> PSOLICITUDES { get; set; }

        public virtual ICollection<SUBTIPOS> SUBTIPOS { get; set; }
    }
}
