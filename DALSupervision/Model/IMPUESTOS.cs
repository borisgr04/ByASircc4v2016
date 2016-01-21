namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.IMPUESTOS")]
    public partial class IMPUESTOS
    {
        public IMPUESTOS()
        {
            IMP_CONTRATOS = new HashSet<IMP_CONTRATOS>();
        }

        [Required]
        [StringLength(100)]
        public string NOM_IMP { get; set; }

        public int? COD_PCT { get; set; }

        [StringLength(2)]
        public string ESTADO { get; set; }

        [Key]
        [StringLength(10)]
        public string NRO_IMP { get; set; }

        public virtual ICollection<IMP_CONTRATOS> IMP_CONTRATOS { get; set; }
    }
}
