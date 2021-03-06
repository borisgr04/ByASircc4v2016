namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.ESTPREV")]
    public partial class ESTPREV
    {
        public ESTPREV()
        {
            EP_CAP_JUR = new HashSet<EP_CAP_JUR>();
            EP_CDP = new HashSet<EP_CDP>();
            EP_CLAUSULAS = new HashSet<EP_CLAUSULAS>();
            EP_CONMUN = new HashSet<EP_CONMUN>();
            EP_ESPTEC = new HashSet<EP_ESPTEC>();
            EP_FORMA_PAGO = new HashSet<EP_FORMA_PAGO>();
            EP_OBLIGACIONESC = new HashSet<EP_OBLIGACIONESC>();
            EP_OBLIGACIONESE = new HashSet<EP_OBLIGACIONESE>();
            EP_POLIZAS = new HashSet<EP_POLIZAS>();
            EP_POLIZAS2 = new HashSet<EP_POLIZAS2>();
            EP_PROYECTOS = new HashSet<EP_PROYECTOS>();
            EP_RIESGOS = new HashSet<EP_RIESGOS>();
            EP_UNSPSC = new HashSet<EP_UNSPSC>();
        }

        public decimal ID { get; set; }

        [StringLength(2000)]
        public string OBJE_EP { get; set; }

        public decimal? PLAZ1_EP { get; set; }

        [StringLength(1)]
        public string TPLA1_EP { get; set; }

        public decimal? PLAZ2_EP { get; set; }

        [StringLength(1)]
        public string TPLA2_EP { get; set; }

        [StringLength(300)]
        public string LUGE_EP { get; set; }

        public decimal? PLIQ_EP { get; set; }

        public decimal? VAL_ENT_EP { get; set; }

        public decimal? VAL_OTR_EP { get; set; }

        [StringLength(12)]
        public string IDE_DIL_EP { get; set; }

        [StringLength(2)]
        public string DEP_NEC_EP { get; set; }

        [StringLength(5)]
        public string STIP_CON_EP { get; set; }

        public DateTime? FEC_ELA_EP { get; set; }

        public DateTime? FEC_REG_EP { get; set; }

        public DateTime? FEC_MOD_EP { get; set; }

        [StringLength(12)]
        public string USAP_REG_EP { get; set; }

        [StringLength(12)]
        public string USAP_MOD_EP { get; set; }

        public DateTime? FEC_REV_EP { get; set; }

        [StringLength(12)]
        public string USAP_REV_EP { get; set; }

        [StringLength(12)]
        public string USAP_ELA_EP { get; set; }

        public DateTime? FEC_ELAS_EP { get; set; }

        [StringLength(12)]
        public string USAP_APR_EP { get; set; }

        public DateTime? FEC_APR_EP { get; set; }

        [StringLength(12)]
        public string USAP_ANU_EP { get; set; }

        public DateTime? FEC_ANU_EP { get; set; }

        [StringLength(12)]
        public string USAP_DAN_EP { get; set; }

        public DateTime? FEC_DAN_EP { get; set; }

        [StringLength(2)]
        public string DEP_SUP_EP { get; set; }

        [StringLength(4)]
        public string VIG_EP { get; set; }

        [StringLength(10)]
        public string CODIGO_EP { get; set; }

        public decimal? GRUPOS_EP { get; set; }

        public decimal? NUM_EMP_EP { get; set; }

        [StringLength(12)]
        public string IDE_RES_EP { get; set; }

        [StringLength(4)]
        public string MOD_SEL_EP { get; set; }

        public decimal? NRO_EP { get; set; }

        [StringLength(2)]
        public string EST_EP { get; set; }

        [StringLength(2)]
        public string EST_FLU_EP { get; set; }

        [StringLength(1)]
        public string ES_PLAN_EP { get; set; }

        [StringLength(2)]
        public string DEP_DEL_EP { get; set; }

        [StringLength(2)]
        public string ENPLANC_EP { get; set; }

        [StringLength(100)]
        public string NOM_PLA_EP { get; set; }

        public decimal? ID_REV { get; set; }

        public decimal? ID_APR { get; set; }

        public string OBLIGC { get; set; }

        public string OBLIGE { get; set; }

        [StringLength(2)]
        public string PERSONA_APOYO { get; set; }

        public decimal? ANTI_PORC { get; set; }

        [StringLength(2)]
        public string TIPO_FP { get; set; }

        [StringLength(12)]
        public string IDE_CON_EP { get; set; }

        [StringLength(12)]
        public string IDE_REP_EP { get; set; }

        public string NEC_EP { get; set; }

        public string OBLIGGRC { get; set; }

        public string OBLIGGRE { get; set; }

        public string JUST_VALOR_EP { get; set; }

        public string CAP_JURIDICA_EP { get; set; }

        public string CAP_FINANCIERA_EP { get; set; }

        public string CAP_RESIDUAL_EP { get; set; }

        public string PERS_LEGAL_EP { get; set; }

        public string PERS_ORGA_EP { get; set; }

        public string CAP_EXPERIENCA_EP { get; set; }

        public string NEC_CONT_INT_EP { get; set; }

        public string SOM_ACUE_COMER_EP { get; set; }

        public string CONST_CUMP_DEBERES_EP { get; set; }

        [StringLength(12)]
        public string IDE_SUP_EP { get; set; }

        [StringLength(100)]
        public string CAR_SUP_EP { get; set; }

        [StringLength(100)]
        public string COD_UNSPSC_EP { get; set; }

        [StringLength(2000)]
        public string DES_UNSPSC_EP { get; set; }

        public string ESP_OBJ_EP { get; set; }

        public string AUTPERLIC_EP { get; set; }

        public string DOCTECNICOS_EP { get; set; }

        public string VARIABLESPPTO_EP { get; set; }

        public string IDONEIDAD_EP { get; set; }

        public string CAP_ORGANIZACIONAL_EP { get; set; }

        public string FACTORES_EVALUACION_EP { get; set; }

        public string REGLAS_DESEMPATE_EP { get; set; }

        [StringLength(1)]
        public string TIPO_PPTO { get; set; }

        public int? PAAID { get; set; }

        [StringLength(400)]
        public string PAADESC { get; set; }

        public string FUN_JUR_MOD { get; set; }

        public string CONSIDERACIONES_EP { get; set; }

        public string ACT_CONT_EP { get; set; }

        public string DESC_APORTES_PROPIOS_EP { get; set; }

        [StringLength(1)]
        public string REQ_CDP_EP { get; set; }

        public string OBS_CDP_EP { get; set; }

        public string OBS_POL_EP { get; set; }

        [StringLength(1)]
        public string REQ_POL_EP { get; set; }

        [StringLength(3)]
        public string INICIO_APARTIR_DE_EP { get; set; }

        public DateTime? FEC_INICIO_EP { get; set; }

        public DateTime? FEC_FIN_EP { get; set; }

        public DateTime? FEC_SUS_EP { get; set; }

        [StringLength(100)]
        public string CAR_RES_EP { get; set; }

        public virtual DEPENDENCIA DEPENDENCIA { get; set; }

        public virtual DEPENDENCIA DEPENDENCIA1 { get; set; }

        public virtual DEPENDENCIA DEPENDENCIA2 { get; set; }

        public virtual ICollection<EP_CAP_JUR> EP_CAP_JUR { get; set; }

        public virtual ICollection<EP_CDP> EP_CDP { get; set; }

        public virtual ICollection<EP_CLAUSULAS> EP_CLAUSULAS { get; set; }

        public virtual ICollection<EP_CONMUN> EP_CONMUN { get; set; }

        public virtual ICollection<EP_ESPTEC> EP_ESPTEC { get; set; }

        public virtual EP_ESTADOS EP_ESTADOS { get; set; }

        public virtual EP_ESTFLU EP_ESTFLU { get; set; }

        public virtual ICollection<EP_FORMA_PAGO> EP_FORMA_PAGO { get; set; }

        public virtual EP_HESTADOEP EP_HESTADOEP { get; set; }

        public virtual EP_HESTADOEP EP_HESTADOEP1 { get; set; }

        public virtual ICollection<EP_OBLIGACIONESC> EP_OBLIGACIONESC { get; set; }

        public virtual ICollection<EP_OBLIGACIONESE> EP_OBLIGACIONESE { get; set; }

        public virtual EP_PAA EP_PAA { get; set; }

        public virtual ICollection<EP_POLIZAS> EP_POLIZAS { get; set; }

        public virtual ICollection<EP_POLIZAS2> EP_POLIZAS2 { get; set; }

        public virtual ICollection<EP_PROYECTOS> EP_PROYECTOS { get; set; }

        public virtual ICollection<EP_RIESGOS> EP_RIESGOS { get; set; }

        public virtual ICollection<EP_UNSPSC> EP_UNSPSC { get; set; }

        public virtual TERCEROS TERCEROS { get; set; }

        public virtual TERCEROS TERCEROS1 { get; set; }

        public virtual TERCEROS TERCEROS2 { get; set; }

        public virtual TERCEROS TERCEROS3 { get; set; }

        public virtual TERCEROS TERCEROS4 { get; set; }

        public virtual TERCEROS TERCEROS5 { get; set; }

        public virtual TERCEROS TERCEROS6 { get; set; }

        public virtual SUBTIPOS SUBTIPOS { get; set; }

        public virtual TIPO_PLAZOS TIPO_PLAZOS { get; set; }

        public virtual TIPO_PLAZOS TIPO_PLAZOS1 { get; set; }

        public virtual TERCEROS TERCEROS7 { get; set; }

        public virtual TERCEROS TERCEROS8 { get; set; }

        public virtual TIPOSPROC TIPOSPROC { get; set; }
    }
}
