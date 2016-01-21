namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.EP_POLIZAS2")]
    public partial class EP_POLIZAS2
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

        public decimal? ID_EP { get; set; }

        public virtual ESTPREV ESTPREV { get; set; }

        public virtual POLIZAS POLIZAS { get; set; }
    }
}
