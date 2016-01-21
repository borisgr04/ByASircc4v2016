namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.TERCEROS")]
    public partial class TERCEROS
    {
        public TERCEROS()
        {
            CONSORCIOSUTXC = new HashSet<CONSORCIOSUTXC>();
            CONSORCIOSUTXC1 = new HashSet<CONSORCIOSUTXC>();
            CONTRATOS = new HashSet<CONTRATOS>();
            ESTPREV = new HashSet<ESTPREV>();
            ESTPREV1 = new HashSet<ESTPREV>();
            ESTPREV2 = new HashSet<ESTPREV>();
            ESTPREV3 = new HashSet<ESTPREV>();
            ESTPREV4 = new HashSet<ESTPREV>();
            ESTPREV5 = new HashSet<ESTPREV>();
            ESTPREV6 = new HashSet<ESTPREV>();
            ESTPREV7 = new HashSet<ESTPREV>();
            ESTPREV8 = new HashSet<ESTPREV>();
            HDEP_ABOGADOS = new HashSet<HDEP_ABOGADOS>();
            HREVISADO = new HashSet<HREVISADO>();
            INTERVENTORES_CONTRATO = new HashSet<INTERVENTORES_CONTRATO>();
            PCONTRATOS = new HashSet<PCONTRATOS>();
            PPROPONENTESS = new HashSet<PPROPONENTESS>();
            PPROPONENTESS1 = new HashSet<PPROPONENTESS>();
            PSOLICITUDES = new HashSet<PSOLICITUDES>();
            PSOLICITUDES1 = new HashSet<PSOLICITUDES>();
            CONSORCIOSUT = new HashSet<CONSORCIOSUT>();
            CONTRATOS1 = new HashSet<CONTRATOS>();
        }

        [Key]
        [StringLength(15)]
        public string IDE_TER { get; set; }

        [Required]
        [StringLength(1000)]
        public string APE1_TER { get; set; }

        [StringLength(50)]
        public string DIR_TER { get; set; }

        [StringLength(50)]
        public string TEL_TER { get; set; }

        [StringLength(50)]
        public string EMA_TER { get; set; }

        [StringLength(100)]
        public string APE2_TER { get; set; }

        [StringLength(15)]
        public string NOM1_TER { get; set; }

        [StringLength(15)]
        public string NOM2_TER { get; set; }

        [StringLength(3)]
        public string TIP_IDE { get; set; }

        [StringLength(50)]
        public string EXP_IDE { get; set; }

        [StringLength(1)]
        public string DV_TER { get; set; }

        [StringLength(500)]
        public string RAZ_SOC { get; set; }

        [StringLength(1)]
        public string ORD_GAS { get; set; }

        [StringLength(50)]
        public string CAR_FUN { get; set; }

        [StringLength(50)]
        public string DOC_DEL { get; set; }

        public DateTime? FEC_DEL { get; set; }

        [StringLength(4)]
        public string DEP_NEC { get; set; }

        [StringLength(2)]
        public string ESTADO { get; set; }

        [StringLength(2)]
        public string TIPO { get; set; }

        public DateTime? FEC_NAC { get; set; }

        public DateTime? FEC_REG { get; set; }

        public DateTime? FEC_MOD { get; set; }

        [StringLength(20)]
        public string USAP { get; set; }

        [StringLength(20)]
        public string USAPM { get; set; }

        [StringLength(10)]
        public string TIP_PER { get; set; }

        public virtual ICollection<CONSORCIOSUTXC> CONSORCIOSUTXC { get; set; }

        public virtual ICollection<CONSORCIOSUTXC> CONSORCIOSUTXC1 { get; set; }

        public virtual ICollection<CONTRATOS> CONTRATOS { get; set; }

        public virtual ICollection<ESTPREV> ESTPREV { get; set; }

        public virtual ICollection<ESTPREV> ESTPREV1 { get; set; }

        public virtual ICollection<ESTPREV> ESTPREV2 { get; set; }

        public virtual ICollection<ESTPREV> ESTPREV3 { get; set; }

        public virtual ICollection<ESTPREV> ESTPREV4 { get; set; }

        public virtual ICollection<ESTPREV> ESTPREV5 { get; set; }

        public virtual ICollection<ESTPREV> ESTPREV6 { get; set; }

        public virtual ICollection<ESTPREV> ESTPREV7 { get; set; }

        public virtual ICollection<ESTPREV> ESTPREV8 { get; set; }

        public virtual ICollection<HDEP_ABOGADOS> HDEP_ABOGADOS { get; set; }

        public virtual ICollection<HREVISADO> HREVISADO { get; set; }

        public virtual ICollection<INTERVENTORES_CONTRATO> INTERVENTORES_CONTRATO { get; set; }

        public virtual ICollection<PCONTRATOS> PCONTRATOS { get; set; }

        public virtual ICollection<PPROPONENTESS> PPROPONENTESS { get; set; }

        public virtual ICollection<PPROPONENTESS> PPROPONENTESS1 { get; set; }

        public virtual ICollection<PSOLICITUDES> PSOLICITUDES { get; set; }

        public virtual ICollection<PSOLICITUDES> PSOLICITUDES1 { get; set; }

        public virtual ICollection<CONSORCIOSUT> CONSORCIOSUT { get; set; }

        public virtual ICollection<CONTRATOS> CONTRATOS1 { get; set; }
    }
}
