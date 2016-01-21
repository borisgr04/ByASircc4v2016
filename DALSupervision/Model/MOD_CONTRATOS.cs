namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.MOD_CONTRATOS")]
    public partial class MOD_CONTRATOS
    {
        [Key]
        [Column(Order = 0)]
        public decimal NUM_SOL_ADI { get; set; }

        public int NRO_CON { get; set; }

        [StringLength(15)]
        public string IDE_CON { get; set; }

        [Required]
        [StringLength(4000)]
        public string OBJ_CON { get; set; }

        [StringLength(100)]
        public string PRO_CON { get; set; }

        public DateTime FEC_SUS_CON { get; set; }

        public int PLA_EJE_CON { get; set; }

        [Required]
        [StringLength(5)]
        public string DEP_CON { get; set; }

        public short VIG_CON { get; set; }

        [Required]
        [StringLength(5)]
        public string TIP_CON { get; set; }

        [Required]
        [StringLength(5)]
        public string STIP_CON { get; set; }

        [Required]
        [StringLength(3)]
        public string EST_CON { get; set; }

        public decimal VAL_CON { get; set; }

        [StringLength(255)]
        public string DOC_CON { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(15)]
        public string COD_CON { get; set; }

        public int CAN_ADI { get; set; }

        public int VAL_ADI { get; set; }

        [Required]
        [StringLength(5)]
        public string COD_SEC { get; set; }

        [Required]
        [StringLength(15)]
        public string TIP_FOR { get; set; }

        [StringLength(200)]
        public string OTR_CNS { get; set; }

        [Required]
        [StringLength(4)]
        public string COD_TPRO { get; set; }

        [StringLength(10)]
        public string NRO_PLA_CON { get; set; }

        [StringLength(15)]
        public string IDE_REP { get; set; }

        [Required]
        [StringLength(15)]
        public string USUARIO { get; set; }

        public DateTime? FEC_REG { get; set; }

        [StringLength(100)]
        public string OBS_DOC_CON { get; set; }

        [StringLength(1)]
        public string URG_MAN { get; set; }

        [StringLength(1)]
        public string EST_CONV { get; set; }

        public DateTime? FEC_APR_POL { get; set; }

        [StringLength(1)]
        public string EXO_IMP { get; set; }

        [StringLength(100)]
        public string EXO_OBS { get; set; }

        [StringLength(20)]
        public string PRO_SEL_NRO { get; set; }

        [StringLength(5)]
        public string DEP_PCON { get; set; }

        public decimal? VAL_APO_GOB { get; set; }

        [StringLength(15)]
        public string COD_CON0 { get; set; }

        public DateTime? FEC_ULT_MOD { get; set; }

        [StringLength(12)]
        public string USER_ACT { get; set; }

        [StringLength(1)]
        public string LEGALIZADO { get; set; }

        [StringLength(1)]
        public string PER_APO { get; set; }

        [StringLength(1)]
        public string ANTICIPO { get; set; }

        public int? NEMPLEOS { get; set; }

        [StringLength(1)]
        public string AGOTAR_PPTO { get; set; }

        [StringLength(100)]
        public string LUG_EJE { get; set; }

        [StringLength(20)]
        public string NUM_PROC { get; set; }

        [StringLength(1)]
        public string TIPO_PLAZO { get; set; }

        [StringLength(1)]
        public string TIP_RADICACION { get; set; }

        public int? GRUPO { get; set; }

        [StringLength(15)]
        public string ENCARGADO { get; set; }

        [StringLength(2)]
        public string MOD_ESTADO { get; set; }

        public decimal? PLAZO2_EJE_CON { get; set; }

        [StringLength(1)]
        public string TIPO_PLAZO2 { get; set; }

        public decimal? VAL_SIN_IVA { get; set; }

        [StringLength(5)]
        public string INTERVENTORIA { get; set; }

        public string CONSIDERANDOS { get; set; }

        public string APORTES { get; set; }

        [StringLength(500)]
        public string SQL_UPDATE { get; set; }

        public decimal? PLAZO1_ADI { get; set; }

        [StringLength(1)]
        public string TIPO_PLAZO1_ADI { get; set; }

        public decimal? PLAZO2_ADI { get; set; }

        [StringLength(1)]
        public string TIPO_PLAZO2_ADI { get; set; }

        public decimal? VAL_CON_ADI { get; set; }

        public decimal? VAL_APO_GOB_ADI { get; set; }

        public decimal? VAL_SIN_IVA_ADI { get; set; }

        public string OBS_POLIZA { get; set; }

        public string OBS_CDP { get; set; }

        public string OBS_PROYECTOS { get; set; }

        [StringLength(15)]
        public string REVISADOPOR { get; set; }

        public virtual DEPENDENCIA DEPENDENCIA { get; set; }

        public virtual DEPENDENCIA DEPENDENCIA1 { get; set; }

        public virtual ESTADOS ESTADOS { get; set; }

        public virtual SECTOR SECTOR { get; set; }

        public virtual SUBTIPOS SUBTIPOS { get; set; }

        public virtual TIPOSCONT TIPOSCONT { get; set; }

        public virtual TIPO_PLAZOS TIPO_PLAZOS { get; set; }

        public virtual PCONTRATOS PCONTRATOS { get; set; }
    }
}
