namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.SUBTIPOS")]
    public partial class SUBTIPOS
    {
        public SUBTIPOS()
        {
            CONTRATOS = new HashSet<CONTRATOS>();
            ESTPREV = new HashSet<ESTPREV>();
            MOD_CONTRATOS = new HashSet<MOD_CONTRATOS>();
            PSOLICITUDES = new HashSet<PSOLICITUDES>();
        }

        [Key]
        [StringLength(10)]
        public string COD_STIP { get; set; }

        [Required]
        [StringLength(50)]
        public string NOM_STIP { get; set; }

        [Required]
        [StringLength(10)]
        public string COD_TIP { get; set; }

        [StringLength(3)]
        public string CLA_CON_DEP { get; set; }

        [StringLength(20)]
        public string CRT_F20_1A { get; set; }

        [StringLength(10)]
        public string CLA_CON_DP { get; set; }

        [StringLength(2)]
        public string ESTADO { get; set; }

        public virtual ICollection<CONTRATOS> CONTRATOS { get; set; }

        public virtual ICollection<ESTPREV> ESTPREV { get; set; }

        public virtual ICollection<MOD_CONTRATOS> MOD_CONTRATOS { get; set; }

        public virtual ICollection<PSOLICITUDES> PSOLICITUDES { get; set; }

        public virtual TIPOSCONT TIPOSCONT { get; set; }
    }
}
