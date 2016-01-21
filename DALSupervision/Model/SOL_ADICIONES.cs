namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.SOL_ADICIONES")]
    public partial class SOL_ADICIONES
    {
        public SOL_ADICIONES()
        {
            MIN_MOD_CONTRATO = new HashSet<MIN_MOD_CONTRATO>();
            MOD_CDP_CONTRATOS = new HashSet<MOD_CDP_CONTRATOS>();
            MOD_COBLIGACIONES = new HashSet<MOD_COBLIGACIONES>();
        }

        [Key]
        [StringLength(15)]
        public string NUM_SOL_ADI { get; set; }

        public DateTime? FEC_SUS_ADI { get; set; }

        [Required]
        [StringLength(15)]
        public string COD_CON { get; set; }

        [Required]
        [StringLength(10)]
        public string TIP_ADI { get; set; }

        [StringLength(300)]
        public string OBSER { get; set; }

        [StringLength(15)]
        public string ID_ABOG_ENC { get; set; }

        public DateTime? FECHA_ASIGNADO { get; set; }

        public DateTime? FECHA_REGISTRO { get; set; }

        [StringLength(15)]
        public string USAP { get; set; }

        [StringLength(15)]
        public string USBD { get; set; }

        public DateTime? FEC_MOD { get; set; }

        public DateTime? FEC_RECIBIDO { get; set; }

        public virtual ICollection<MIN_MOD_CONTRATO> MIN_MOD_CONTRATO { get; set; }

        public virtual ICollection<MOD_CDP_CONTRATOS> MOD_CDP_CONTRATOS { get; set; }

        public virtual ICollection<MOD_COBLIGACIONES> MOD_COBLIGACIONES { get; set; }

        public virtual HREVSOLADI HREVSOLADI { get; set; }

        public virtual MOD_CPROYECTOS MOD_CPROYECTOS { get; set; }
    }
}
