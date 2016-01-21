namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.ADICIONES")]
    public partial class ADICIONES
    {
        [Key]
        [StringLength(15)]
        public string NRO_ADI { get; set; }

        public DateTime FEC_SUS_ADI { get; set; }

        public int PLA_EJE_ADI { get; set; }

        public short VIG_ADI { get; set; }

        public decimal VAL_ADI { get; set; }

        [StringLength(255)]
        public string DOC_ADI { get; set; }

        [Required]
        [StringLength(15)]
        public string COD_CON { get; set; }

        [StringLength(10)]
        public string TIP_ADI { get; set; }

        [StringLength(1)]
        public string LEGALIZADO { get; set; }

        public DateTime? FEC_APR_POL { get; set; }

        [StringLength(2000)]
        public string OBSER { get; set; }

        [StringLength(1)]
        public string EXENPOL { get; set; }

        [StringLength(1)]
        public string TIPO_PLAZO1_ADI { get; set; }

        public decimal? PLAZO2_ADI { get; set; }

        [StringLength(1)]
        public string TIPO_PLAZO2_ADI { get; set; }

        public decimal? VAL_APO_GOB_ADI { get; set; }

        public decimal? VAL_SIN_IVA_ADI { get; set; }

        [StringLength(20)]
        public string RES_APR_POL { get; set; }

        public DateTime? FEC_REG { get; set; }

        [StringLength(20)]
        public string USAP { get; set; }

        [StringLength(20)]
        public string USBD { get; set; }

        public DateTime? FEC_MOD { get; set; }

        [StringLength(20)]
        public string USAP_M { get; set; }

        [StringLength(20)]
        public string USBD_M { get; set; }

        [StringLength(20)]
        public string DES_MOD { get; set; }

        public virtual CONTRATOS CONTRATOS { get; set; }
    }
}
