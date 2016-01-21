namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.PSOLICITUDES")]
    public partial class PSOLICITUDES
    {
        public PSOLICITUDES()
        {
            HREVISADO = new HashSet<HREVISADO>();
            PCONTRATOS = new HashSet<PCONTRATOS>();
        }

        public decimal NUM_SOL { get; set; }

        [Key]
        [StringLength(20)]
        public string COD_SOL { get; set; }

        [Required]
        [StringLength(5)]
        public string DEP_SOL { get; set; }

        [Required]
        [StringLength(5)]
        public string DEP_PSOL { get; set; }

        public short VIG_SOL { get; set; }

        [Required]
        [StringLength(5)]
        public string TIP_CON { get; set; }

        [Required]
        [StringLength(5)]
        public string STIP_CON { get; set; }

        [Required]
        [StringLength(4)]
        public string COD_TPRO { get; set; }

        [Required]
        [StringLength(4000)]
        public string OBJ_SOL { get; set; }

        [StringLength(15)]
        public string ID_ABOG_ENC { get; set; }

        public DateTime? FECHA_ASIGNADO { get; set; }

        public DateTime? FECHA_REGISTRO { get; set; }

        [StringLength(15)]
        public string USAP { get; set; }

        [StringLength(15)]
        public string USBD { get; set; }

        public DateTime? FEC_MOD { get; set; }

        public decimal? NUM_PLA { get; set; }

        public DateTime? FEC_RECIBIDO { get; set; }

        public decimal? VAL_CON { get; set; }

        [StringLength(10)]
        public string COD_EP { get; set; }

        [StringLength(20)]
        public string USAP_MOD { get; set; }

        public decimal? ID_HREV { get; set; }

        [StringLength(20)]
        public string IDE_CON { get; set; }

        public virtual DEPENDENCIA DEPENDENCIA { get; set; }

        public virtual DEPENDENCIA DEPENDENCIA1 { get; set; }

        public virtual ICollection<HREVISADO> HREVISADO { get; set; }

        public virtual HREVISADO HREVISADO1 { get; set; }

        public virtual ICollection<PCONTRATOS> PCONTRATOS { get; set; }

        public virtual TERCEROS TERCEROS { get; set; }

        public virtual TIPOSPROC TIPOSPROC { get; set; }

        public virtual SUBTIPOS SUBTIPOS { get; set; }

        public virtual TIPOSCONT TIPOSCONT { get; set; }

        public virtual TERCEROS TERCEROS1 { get; set; }
    }
}
