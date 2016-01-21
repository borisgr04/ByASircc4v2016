namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.MOD_PROPONENTES")]
    public partial class MOD_PROPONENTES
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(15)]
        public string NUM_SOL_ADI { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string IDE_PROP { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string NUM_PROC { get; set; }

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

        public decimal? VAL_PROP { get; set; }

        public DateTime? FEC_PROP { get; set; }

        [StringLength(1)]
        public string ADJUDICADO { get; set; }

        public DateTime? FECHA_ADJUDICACION { get; set; }

        [StringLength(300)]
        public string OBSERVACION_ADJUDICACION { get; set; }

        [StringLength(100)]
        public string APE1_PROP { get; set; }

        [StringLength(50)]
        public string DIR_PROP { get; set; }

        [StringLength(50)]
        public string TEL_PROP { get; set; }

        [StringLength(50)]
        public string EMAIL_PROP { get; set; }

        [StringLength(100)]
        public string APE2_PROP { get; set; }

        [StringLength(15)]
        public string NOM1_PROP { get; set; }

        [StringLength(15)]
        public string NOM2_PROP { get; set; }

        [StringLength(3)]
        public string TIP_IDE { get; set; }

        [StringLength(50)]
        public string EXP_IDE { get; set; }

        [StringLength(1)]
        public string DV_TER { get; set; }

        [StringLength(500)]
        public string RAZON_SOCIAL { get; set; }

        [StringLength(1)]
        public string ORD_GAS { get; set; }

        [StringLength(50)]
        public string CAR_FUN { get; set; }

        [StringLength(50)]
        public string DOC_DEL { get; set; }

        public DateTime? FEC_DEL { get; set; }

        [StringLength(2)]
        public string TIPO { get; set; }

        [StringLength(2)]
        public string ESTADO { get; set; }

        [StringLength(2000)]
        public string OBSERVACION { get; set; }

        public decimal? NUM_FOLIO { get; set; }

        [StringLength(20)]
        public string ID_REP_LEGAL { get; set; }

        [StringLength(100)]
        public string NOM_REP_LEGAL { get; set; }

        [StringLength(6)]
        public string COD_AUX { get; set; }

        [StringLength(100)]
        public string MUNICIPIO { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GRUPO { get; set; }

        [StringLength(20)]
        public string NUMPOLIZA { get; set; }

        public DateTime? FECHA_INICIAL { get; set; }

        public DateTime? FECHA_FINAL { get; set; }

        public int? ASEGURADORA { get; set; }

        public int? NOM_POLIZA { get; set; }

        public decimal? VALOR_POLIZA { get; set; }

        [StringLength(100)]
        public string DENOMINACION { get; set; }

        public string APORTES { get; set; }

        [StringLength(500)]
        public string SQL_UPDATE { get; set; }

        public virtual GPROCESOS GPROCESOS { get; set; }

        public virtual TIPPROPONENTE TIPPROPONENTE { get; set; }
    }
}
