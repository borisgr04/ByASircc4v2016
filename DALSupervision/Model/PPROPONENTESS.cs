namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.PPROPONENTESS")]
    public partial class PPROPONENTESS
    {
        public PPROPONENTESS()
        {
            CONSORCIOSUTXC = new HashSet<CONSORCIOSUTXC>();
        }

        public decimal ID { get; set; }

        [StringLength(2)]
        public string TIPO_PROP { get; set; }

        [StringLength(20)]
        public string NUM_PROC { get; set; }

        public DateTime? FEC_PROP { get; set; }

        public decimal? VAL_PROP { get; set; }

        public decimal? NUM_FOLIO { get; set; }

        [StringLength(30)]
        public string IDE_PROP { get; set; }

        [StringLength(3)]
        public string TIP_IDE_PROP { get; set; }

        [StringLength(50)]
        public string EXP_IDE_PROP { get; set; }

        [StringLength(1)]
        public string DV_PROP { get; set; }

        [StringLength(10)]
        public string TIP_PER_PROP { get; set; }

        [StringLength(1000)]
        public string APE1_PROP { get; set; }

        [StringLength(100)]
        public string APE2_PROP { get; set; }

        [StringLength(15)]
        public string NOM1_PROP { get; set; }

        [StringLength(15)]
        public string NOM2_PROP { get; set; }

        [StringLength(500)]
        public string RAZ_SOC { get; set; }

        [StringLength(50)]
        public string DIR_PROP { get; set; }

        [StringLength(50)]
        public string TEL_PROP { get; set; }

        [StringLength(50)]
        public string EMA_PROP { get; set; }

        public DateTime? FEC_NAC { get; set; }

        [StringLength(1)]
        public string ADJUDICADO { get; set; }

        public DateTime? FEC_ADJUDICACION { get; set; }

        [StringLength(300)]
        public string OBS_ADJUDICACION { get; set; }

        [StringLength(2)]
        public string ESTADO { get; set; }

        [StringLength(6)]
        public string COD_AUX { get; set; }

        [StringLength(20)]
        public string ID_REP_LEGAL { get; set; }

        [StringLength(100)]
        public string MUNICIPIO { get; set; }

        public DateTime? FEC_REG { get; set; }

        [StringLength(20)]
        public string USBD { get; set; }

        [StringLength(20)]
        public string USAP { get; set; }

        public DateTime? FEC_MOD { get; set; }

        [StringLength(20)]
        public string USBD_MOD { get; set; }

        [StringLength(20)]
        public string USAP_MOD { get; set; }

        public string APORTES { get; set; }

        [StringLength(20)]
        public string NUMPOLIZA { get; set; }

        public DateTime? FECHA_INICIAL { get; set; }

        public DateTime? FECHA_FINAL { get; set; }

        public int? ASEGURADORA { get; set; }

        public int? NOM_POLIZA { get; set; }

        public decimal? VALOR_POLIZA { get; set; }

        [StringLength(100)]
        public string DENOMINACION { get; set; }

        public decimal? VAL_SIN_IVA { get; set; }

        public virtual ASEGURADORAS ASEGURADORAS { get; set; }

        public virtual ICollection<CONSORCIOSUTXC> CONSORCIOSUTXC { get; set; }

        public virtual PCONTRATOS PCONTRATOS { get; set; }

        public virtual POLIZAS POLIZAS { get; set; }

        public virtual TIPPROPONENTE TIPPROPONENTE { get; set; }

        public virtual TERCEROS TERCEROS { get; set; }

        public virtual TERCEROS TERCEROS1 { get; set; }
    }
}
