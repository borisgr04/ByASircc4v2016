namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.C_POLIZAS2")]
    public partial class C_POLIZAS2
    {
        public decimal ID { get; set; }

        public int? COD_POL { get; set; }

        [StringLength(1000)]
        public string DES_POL { get; set; }

        [StringLength(10)]
        public string PLA_POL { get; set; }

        [StringLength(10)]
        public string VAL_POL { get; set; }

        public int? GRUPO { get; set; }

        [StringLength(10)]
        public string COD_CON { get; set; }

        public virtual CONTRATOS CONTRATOS { get; set; }

        public virtual POLIZAS POLIZAS { get; set; }
    }
}
