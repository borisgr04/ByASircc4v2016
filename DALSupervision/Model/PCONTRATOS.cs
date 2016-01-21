namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.PCONTRATOS")]
    public partial class PCONTRATOS
    {
        public PCONTRATOS()
        {
            CONTRATOS = new HashSet<CONTRATOS>();
            DOC_PLANTILLA = new HashSet<DOC_PLANTILLA>();
            GPROCESOS = new HashSet<GPROCESOS>();
            MOD_CONTRATOS = new HashSet<MOD_CONTRATOS>();
            PAGOS_PARCIALES = new HashSet<PAGOS_PARCIALES>();
            PCONMUN = new HashSet<PCONMUN>();
            CDP_PCONTRATOS = new HashSet<CDP_PCONTRATOS>();
            PPOLIZAS = new HashSet<PPOLIZAS>();
            PCRONOGRAMAS = new HashSet<PCRONOGRAMAS>();
            POBLIGACIONES = new HashSet<POBLIGACIONES>();
            PPROPONENTES = new HashSet<PPROPONENTES>();
            PPROPONENTESS = new HashSet<PPROPONENTESS>();
            RUBROS_PCONTRATOS = new HashSet<RUBROS_PCONTRATOS>();
        }

        [Key]
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

        [StringLength(100)]
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

        public int? NUMGRUPOS { get; set; }

        public virtual AN_PCONTRATO AN_PCONTRATO { get; set; }

        public virtual ICollection<CONTRATOS> CONTRATOS { get; set; }

        public virtual DEPENDENCIA DEPENDENCIA { get; set; }

        public virtual DEPENDENCIA DEPENDENCIA1 { get; set; }

        public virtual ICollection<DOC_PLANTILLA> DOC_PLANTILLA { get; set; }

        public virtual ICollection<GPROCESOS> GPROCESOS { get; set; }

        public virtual ICollection<MOD_CONTRATOS> MOD_CONTRATOS { get; set; }

        public virtual ICollection<PAGOS_PARCIALES> PAGOS_PARCIALES { get; set; }

        public virtual ICollection<PCONMUN> PCONMUN { get; set; }

        public virtual ICollection<CDP_PCONTRATOS> CDP_PCONTRATOS { get; set; }

        public virtual ICollection<PPOLIZAS> PPOLIZAS { get; set; }

        public virtual PESTADOS PESTADOS { get; set; }

        public virtual TERCEROS TERCEROS { get; set; }

        public virtual PSOLICITUDES PSOLICITUDES { get; set; }

        public virtual TIPOSPROC TIPOSPROC { get; set; }

        public virtual ICollection<PCRONOGRAMAS> PCRONOGRAMAS { get; set; }

        public virtual ICollection<POBLIGACIONES> POBLIGACIONES { get; set; }

        public virtual ICollection<PPROPONENTES> PPROPONENTES { get; set; }

        public virtual ICollection<PPROPONENTESS> PPROPONENTESS { get; set; }

        public virtual ICollection<RUBROS_PCONTRATOS> RUBROS_PCONTRATOS { get; set; }
    }
}
