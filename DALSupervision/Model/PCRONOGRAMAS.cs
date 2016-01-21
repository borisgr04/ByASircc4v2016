namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.PCRONOGRAMAS")]
    public partial class PCRONOGRAMAS
    {
        public PCRONOGRAMAS()
        {
            PCRONO_DIAS = new HashSet<PCRONO_DIAS>();
        }

        [StringLength(4)]
        public string COD_ACT { get; set; }

        [StringLength(1000)]
        public string NOM_ACT { get; set; }

        [StringLength(10)]
        public string COD_TPRO { get; set; }

        public DateTime? FECHAI { get; set; }

        public decimal? HORAI { get; set; }

        public DateTime? FECHAF { get; set; }

        public decimal? HORAF { get; set; }

        [StringLength(1000)]
        public string UBICACION { get; set; }

        [StringLength(500)]
        public string NOTAS { get; set; }

        [StringLength(2)]
        public string OCUPADO { get; set; }

        [StringLength(4)]
        public string EST_ACT { get; set; }

        [StringLength(4000)]
        public string OBS_SEG { get; set; }

        public DateTime? FEC_REG { get; set; }

        [StringLength(20)]
        public string USAP { get; set; }

        [StringLength(20)]
        public string USBD { get; set; }

        public DateTime? FEC_MOD { get; set; }

        [StringLength(20)]
        public string USAP_MOD { get; set; }

        [StringLength(20)]
        public string USBD_MOD { get; set; }

        [StringLength(20)]
        public string NUM_PROC { get; set; }

        public decimal ID { get; set; }

        [StringLength(6)]
        public string COLOR { get; set; }

        [StringLength(1)]
        public string ANULADO { get; set; }

        [StringLength(2)]
        public string OBLIGATORIO { get; set; }

        [StringLength(2)]
        public string EST_PROC { get; set; }

        public decimal? DIAS_AVISO { get; set; }

        public DateTime FEC_AVISO { get; set; }

        [StringLength(2)]
        public string MIN_I { get; set; }

        [StringLength(2)]
        public string MIN_F { get; set; }

        [StringLength(2)]
        public string NOTIFICAR { get; set; }

        [StringLength(2)]
        public string MFECINI { get; set; }

        [StringLength(2)]
        public string MHORINI { get; set; }

        [StringLength(2)]
        public string MFECFIN { get; set; }

        [StringLength(2)]
        public string MHORFIN { get; set; }

        public int? ORDEN { get; set; }

        [StringLength(2)]
        public string TIPO { get; set; }

        [StringLength(2)]
        public string TIP_PLA { get; set; }

        public virtual PCONTRATOS PCONTRATOS { get; set; }

        public virtual ICollection<PCRONO_DIAS> PCRONO_DIAS { get; set; }

        public virtual PL_TIPOS_PLANTILLA PL_TIPOS_PLANTILLA { get; set; }

        public virtual PESTADOSACT PESTADOSACT { get; set; }
    }
}
