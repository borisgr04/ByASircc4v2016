namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.INT_TRASLADOS")]
    public partial class INT_TRASLADOS
    {
        public INT_TRASLADOS()
        {
            INT_DETTRASLADO = new HashSet<INT_DETTRASLADO>();
        }

        public decimal ID { get; set; }

        public DateTime? FEC_TRA { get; set; }

        [StringLength(2)]
        public string ORI_TRA { get; set; }

        [StringLength(2)]
        public string DES_TRA { get; set; }

        [StringLength(20)]
        public string USAP { get; set; }

        [StringLength(20)]
        public string USAPM { get; set; }

        public DateTime? FEC_MOD { get; set; }

        public DateTime? FEC_REG { get; set; }

        [StringLength(2)]
        public string EST_TRA { get; set; }

        [StringLength(200)]
        public string OBS_TRA { get; set; }

        public virtual ICollection<INT_DETTRASLADO> INT_DETTRASLADO { get; set; }
    }
}
