namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.HREVSOLADI")]
    public partial class HREVSOLADI
    {
        [Key]
        [StringLength(15)]
        public string NUM_SOL_ADI { get; set; }

        public DateTime? FECHA_RECIBIDO { get; set; }

        public DateTime? FEC_REC_ABOG { get; set; }

        [StringLength(1)]
        public string RECIBIDO_ABOG { get; set; }

        [StringLength(300)]
        public string OBS_RECIBIDO_ABOG { get; set; }

        public DateTime? FECHA_REVISADO { get; set; }

        [StringLength(1000)]
        public string OBS_REVISADO { get; set; }

        [StringLength(1)]
        public string CONCEPTO_REVISADO { get; set; }

        public decimal? ID_HREV { get; set; }

        [StringLength(15)]
        public string NIT_ABOG_RECIBE { get; set; }

        [StringLength(200)]
        public string OBSERVACION_RECIBIDO { get; set; }

        public DateTime? FEC_ASIGNADO { get; set; }

        public DateTime? FEC_REG { get; set; }

        [StringLength(15)]
        public string USAP { get; set; }

        [StringLength(15)]
        public string USBD { get; set; }

        public DateTime? FEC_MOD { get; set; }

        public virtual SOL_ADICIONES SOL_ADICIONES { get; set; }
    }
}
