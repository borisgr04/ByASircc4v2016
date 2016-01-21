namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.TIP_DOC")]
    public partial class TIP_DOC
    {
        public TIP_DOC()
        {
            ANX_CONTRATOS = new HashSet<ANX_CONTRATOS>();
            GD_DOC_ACTAS = new HashSet<GD_DOC_ACTAS>();
        }

        [Key]
        [StringLength(2)]
        public string COD_TIP { get; set; }

        [StringLength(100)]
        public string DES_TIP { get; set; }

        [StringLength(2)]
        public string EST_TIP { get; set; }

        [StringLength(2)]
        public string COD_ETAPA { get; set; }

        [StringLength(1)]
        public string ORIGEN { get; set; }

        [StringLength(1)]
        public string DOC_OBLIG { get; set; }

        public virtual ICollection<ANX_CONTRATOS> ANX_CONTRATOS { get; set; }

        public virtual ETAPAS ETAPAS { get; set; }

        public virtual ICollection<GD_DOC_ACTAS> GD_DOC_ACTAS { get; set; }
    }
}
