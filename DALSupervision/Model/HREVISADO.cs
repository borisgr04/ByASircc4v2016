namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.HREVISADO")]
    public partial class HREVISADO
    {
        public HREVISADO()
        {
            PSOLICITUDES1 = new HashSet<PSOLICITUDES>();
        }

        [Required]
        [StringLength(20)]
        public string COD_SOL { get; set; }

        public DateTime? FECHA_RECIBIDO { get; set; }

        public DateTime? FEC_REC_ABOG { get; set; }

        [StringLength(1)]
        public string RECIBIDO_ABOG { get; set; }

        [StringLength(300)]
        public string OBS_RECIBIDO_ABOG { get; set; }

        public DateTime? FECHA_REVISADO { get; set; }

        [StringLength(4000)]
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

        [StringLength(20)]
        public string USAP { get; set; }

        public string HOBS_REVISADO { get; set; }

        [Key]
        public decimal IDE { get; set; }

        public virtual TERCEROS TERCEROS { get; set; }

        public virtual PSOLICITUDES PSOLICITUDES { get; set; }

        public virtual ICollection<PSOLICITUDES> PSOLICITUDES1 { get; set; }
    }
}
