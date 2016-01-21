namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.CONSORCIOSUTXC")]
    public partial class CONSORCIOSUTXC
    {
        [StringLength(15)]
        public string IDE_TER { get; set; }

        [StringLength(15)]
        public string ID_MIEMBROS { get; set; }

        [StringLength(2)]
        public string ID_ESTADO { get; set; }

        public decimal? PORC_PART { get; set; }

        [StringLength(10)]
        public string COD_CON { get; set; }

        public DateTime? FEC_REG { get; set; }

        [StringLength(20)]
        public string USBD { get; set; }

        [StringLength(20)]
        public string USAP { get; set; }

        public decimal ID { get; set; }

        public decimal? ID_PROP { get; set; }

        public virtual TERCEROS TERCEROS { get; set; }

        public virtual PPROPONENTESS PPROPONENTESS { get; set; }

        public virtual TERCEROS TERCEROS1 { get; set; }
    }
}
