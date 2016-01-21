namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.GPROCESOS")]
    public partial class GPROCESOS
    {
        public GPROCESOS()
        {
            GPOBLIGACIONES = new HashSet<GPOBLIGACIONES>();
            GPPOLIZAS = new HashSet<GPPOLIZAS>();
            GPPROPONENTES = new HashSet<GPPROPONENTES>();
            GPPROYECTOS = new HashSet<GPPROYECTOS>();
            RUBROS_GPROCESOS = new HashSet<RUBROS_GPROCESOS>();
            PAGOS_GPROCESOS = new HashSet<PAGOS_GPROCESOS>();
            MOD_PROPONENTES = new HashSet<MOD_PROPONENTES>();
            CDP_GPROCESOS = new HashSet<CDP_GPROCESOS>();
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string PRO_SEL_NRO { get; set; }

        [StringLength(15)]
        public string IDE_CON { get; set; }

        [Required]
        [StringLength(4000)]
        public string OBJ_CON { get; set; }

        [StringLength(100)]
        public string PRO_CON { get; set; }

        public int PLA_EJE_CON { get; set; }

        [Required]
        [StringLength(5)]
        public string DEP_CON { get; set; }

        [Required]
        [StringLength(5)]
        public string DEP_PCON { get; set; }

        public short VIG_CON { get; set; }

        [Required]
        [StringLength(5)]
        public string TIP_CON { get; set; }

        [Required]
        [StringLength(5)]
        public string STIP_CON { get; set; }

        public decimal VAL_CON { get; set; }

        public decimal VAL_APO_GOB { get; set; }

        [StringLength(5)]
        public string COD_SEC { get; set; }

        [StringLength(15)]
        public string TIP_FOR { get; set; }

        [StringLength(200)]
        public string OTR_CNS { get; set; }

        [StringLength(10)]
        public string NRO_PLA_CON { get; set; }

        [StringLength(15)]
        public string IDE_REP { get; set; }

        [StringLength(1)]
        public string URG_MAN { get; set; }

        [StringLength(1)]
        public string EST_CONV { get; set; }

        [StringLength(1)]
        public string APL_GAC { get; set; }

        [Required]
        [StringLength(2)]
        public string EST_CON { get; set; }

        [StringLength(15)]
        public string COD_CON { get; set; }

        public int? NRO_CON { get; set; }

        [StringLength(15)]
        public string USUARIO { get; set; }

        public DateTime? FEC_REG { get; set; }

        [StringLength(15)]
        public string USBD { get; set; }

        public DateTime? FEC_MOD { get; set; }

        [StringLength(255)]
        public string LUG_EJE { get; set; }

        [StringLength(15)]
        public string USUENCARGADO { get; set; }

        public DateTime? FECHAASIG { get; set; }

        public DateTime? FECHARECIBIDO { get; set; }

        [StringLength(20)]
        public string NUM_SOL { get; set; }

        [StringLength(4)]
        public string COD_TPRO { get; set; }

        [StringLength(2)]
        public string ESTADO { get; set; }

        [StringLength(1)]
        public string TIPO_PLAZO { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GRUPO { get; set; }

        [StringLength(500)]
        public string DESC_GRUPO { get; set; }

        public decimal? PLAZO2_EJE_CON { get; set; }

        [StringLength(1)]
        public string TIPO_PLAZO2 { get; set; }

        public decimal? VAL_SIN_IVA { get; set; }

        [StringLength(5)]
        public string INTERVENTORIA { get; set; }

        [StringLength(1)]
        public string AGOTAR_PPTO { get; set; }

        public string CONSIDERANDOS { get; set; }

        public string APORTES { get; set; }

        [StringLength(15)]
        public string REVISADOPOR { get; set; }

        public string OBS_PROYECTOS { get; set; }

        public string OBS_CDP { get; set; }

        public string OBS_POLIZAS { get; set; }

        public virtual ICollection<GPOBLIGACIONES> GPOBLIGACIONES { get; set; }

        public virtual ICollection<GPPOLIZAS> GPPOLIZAS { get; set; }

        public virtual ICollection<GPPROPONENTES> GPPROPONENTES { get; set; }

        public virtual ICollection<GPPROYECTOS> GPPROYECTOS { get; set; }

        public virtual PCONTRATOS PCONTRATOS { get; set; }

        public virtual ICollection<RUBROS_GPROCESOS> RUBROS_GPROCESOS { get; set; }

        public virtual ICollection<PAGOS_GPROCESOS> PAGOS_GPROCESOS { get; set; }

        public virtual ICollection<MOD_PROPONENTES> MOD_PROPONENTES { get; set; }

        public virtual TIPOSPROC TIPOSPROC { get; set; }

        public virtual PESTADOS PESTADOS { get; set; }

        public virtual ICollection<CDP_GPROCESOS> CDP_GPROCESOS { get; set; }
    }
}
