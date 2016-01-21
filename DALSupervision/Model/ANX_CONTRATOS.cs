namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.ANX_CONTRATOS")]
    public partial class ANX_CONTRATOS
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string TIP_DOC { get; set; }

        [StringLength(50)]
        public string NOM_DOC { get; set; }

        [StringLength(4000)]
        public string OBS_DOC { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4000)]
        public string COD_CON { get; set; }

        [StringLength(4000)]
        public string USUARIO { get; set; }

        public DateTime FEC_REG { get; set; }

        public virtual TIP_DOC TIP_DOC1 { get; set; }

        public virtual USUARIOS USUARIOS { get; set; }
    }
}
