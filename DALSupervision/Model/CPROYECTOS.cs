namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.CPROYECTOS")]
    public partial class CPROYECTOS
    {
        [StringLength(30)]
        public string PROYECTO { get; set; }

        [StringLength(20)]
        public string COD_CON { get; set; }

        public DateTime? FEC_REG { get; set; }

        [StringLength(20)]
        public string USBD { get; set; }

        [StringLength(20)]
        public string USAP { get; set; }

        public DateTime? FEC_MOD { get; set; }

        [StringLength(20)]
        public string USBD_MOD { get; set; }

        [StringLength(20)]
        public string USAP_MOD { get; set; }

        public decimal ID { get; set; }

        public virtual CONTRATOS CONTRATOS { get; set; }

        public virtual PROYECTOS PROYECTOS { get; set; }
    }
}
