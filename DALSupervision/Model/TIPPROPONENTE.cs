namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.TIPPROPONENTE")]
    public partial class TIPPROPONENTE
    {
        public TIPPROPONENTE()
        {
            GPPROPONENTES = new HashSet<GPPROPONENTES>();
            MOD_PROPONENTES = new HashSet<MOD_PROPONENTES>();
            PPROPONENTES = new HashSet<PPROPONENTES>();
            PPROPONENTESS = new HashSet<PPROPONENTESS>();
        }

        [Key]
        [StringLength(2)]
        public string COD_TIPPROP { get; set; }

        [StringLength(100)]
        public string NOM_TIPPROP { get; set; }

        public virtual ICollection<GPPROPONENTES> GPPROPONENTES { get; set; }

        public virtual ICollection<MOD_PROPONENTES> MOD_PROPONENTES { get; set; }

        public virtual ICollection<PPROPONENTES> PPROPONENTES { get; set; }

        public virtual ICollection<PPROPONENTESS> PPROPONENTESS { get; set; }
    }
}
