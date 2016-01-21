namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.SECTOR")]
    public partial class SECTOR
    {
        public SECTOR()
        {
            CONTRATOS = new HashSet<CONTRATOS>();
            MOD_CONTRATOS = new HashSet<MOD_CONTRATOS>();
        }

        [Key]
        [StringLength(5)]
        public string COD_SEC { get; set; }

        [Required]
        [StringLength(50)]
        public string NOM_SEC { get; set; }

        [StringLength(2)]
        public string ESTADO { get; set; }

        public virtual ICollection<CONTRATOS> CONTRATOS { get; set; }

        public virtual ICollection<MOD_CONTRATOS> MOD_CONTRATOS { get; set; }
    }
}
