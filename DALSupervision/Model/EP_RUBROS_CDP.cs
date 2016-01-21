namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.EP_RUBROS_CDP")]
    public partial class EP_RUBROS_CDP
    {
        public decimal ID { get; set; }

        public decimal? ID_EP { get; set; }

        [StringLength(50)]
        public string COD_RUB { get; set; }

        public decimal? VALOR { get; set; }

        [StringLength(20)]
        public string NRO_CDP { get; set; }

        public short? VIG_CDP { get; set; }

        public int? GRUPO { get; set; }

        public DateTime? FEC_REG { get; set; }

        [StringLength(12)]
        public string USAP_REG { get; set; }

        public DateTime? FEC_MOD { get; set; }

        [StringLength(12)]
        public string USAP_MOD { get; set; }

        public decimal? ID_EP_CDP { get; set; }

        public virtual EP_CDP EP_CDP { get; set; }

        public virtual RUBROS RUBROS { get; set; }
    }
}
