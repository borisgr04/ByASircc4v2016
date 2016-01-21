namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.EP_CDP")]
    public partial class EP_CDP
    {
        public EP_CDP()
        {
            EP_RUBROS_CDP = new HashSet<EP_RUBROS_CDP>();
        }

        public decimal ID { get; set; }

        public decimal? ID_EP { get; set; }

        [Required]
        [StringLength(10)]
        public string NRO_CDP { get; set; }

        public DateTime FEC_CDP { get; set; }

        public decimal? VAL_CDP { get; set; }

        [StringLength(2)]
        public string VIG_FUT { get; set; }

        public decimal? GRUPO { get; set; }

        public DateTime? FEC_REG { get; set; }

        [StringLength(12)]
        public string USAP_REG { get; set; }

        public DateTime? FEC_MOD { get; set; }

        [StringLength(12)]
        public string USAP_MOD { get; set; }

        public virtual ESTPREV ESTPREV { get; set; }

        public virtual ICollection<EP_RUBROS_CDP> EP_RUBROS_CDP { get; set; }
    }
}
