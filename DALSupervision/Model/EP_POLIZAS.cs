namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.EP_POLIZAS")]
    public partial class EP_POLIZAS
    {
        public decimal ID { get; set; }

        public int? COD_POL { get; set; }

        public decimal? ID_EP { get; set; }

        public decimal? POR_SMMLV { get; set; }

        [StringLength(3)]
        public string CAL_APARTIRDE { get; set; }

        public decimal? VIGENCIA { get; set; }

        [StringLength(5)]
        public string APARTIRDE { get; set; }

        [StringLength(10)]
        public string TIPO { get; set; }

        public int? GRUPO { get; set; }

        public virtual CAL_VIG_POL CAL_VIG_POL { get; set; }

        public virtual CALCULOPOL CALCULOPOL { get; set; }

        public virtual POLIZAS POLIZAS { get; set; }

        public virtual ESTPREV ESTPREV { get; set; }
    }
}
