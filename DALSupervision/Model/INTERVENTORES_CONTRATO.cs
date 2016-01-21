namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.INTERVENTORES_CONTRATO")]
    public partial class INTERVENTORES_CONTRATO
    {
        [StringLength(15)]
        public string IDE_INT { get; set; }

        [Required]
        [StringLength(10)]
        public string COD_CON { get; set; }

        [Required]
        [StringLength(1)]
        public string TIP_INT { get; set; }

        [Required]
        [StringLength(20)]
        public string USUARIO { get; set; }

        public DateTime FEC_REG { get; set; }

        [StringLength(2)]
        public string EST_INT { get; set; }

        [StringLength(200)]
        public string OBS_INT { get; set; }

        [StringLength(20)]
        public string COD_CON_INT { get; set; }

        [Key]
        public decimal IDE { get; set; }

        public virtual CONTRATOS CONTRATOS { get; set; }

        public virtual TERCEROS TERCEROS { get; set; }
    }
}
