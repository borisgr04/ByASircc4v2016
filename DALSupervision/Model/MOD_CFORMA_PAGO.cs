namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.MOD_CFORMA_PAGO")]
    public partial class MOD_CFORMA_PAGO
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(15)]
        public string NUM_SOL_ADI { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal ID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(15)]
        public string COD_CON { get; set; }

        public DateTime? FECHA_PAGO { get; set; }

        [StringLength(2)]
        public string TIPO_PAGO { get; set; }

        public decimal? VALOR_PAGO { get; set; }

        public decimal? PORCENTAJE { get; set; }

        [StringLength(15)]
        public string USUARIO { get; set; }

        public DateTime? FEC_REG { get; set; }

        [StringLength(15)]
        public string USBD { get; set; }

        public DateTime? FEC_MOD { get; set; }

        [StringLength(1)]
        public string PAGA_GOBER { get; set; }

        public string CONDICION_PAGO { get; set; }

        public virtual TIPO_PAGO TIPO_PAGO1 { get; set; }
    }
}
