namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.PAGOS_PARCIALES")]
    public partial class PAGOS_PARCIALES
    {
        [Key]
        [Column(Order = 0)]
        public decimal ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string NUM_PROC { get; set; }

        public DateTime? FECHA_PAGO { get; set; }

        [StringLength(2)]
        public string TIPO_PAGO { get; set; }

        public decimal? VALOR_PAGO { get; set; }

        public decimal? PORCENTAJE { get; set; }

        [StringLength(500)]
        public string CONDICION_PAGO { get; set; }

        [StringLength(15)]
        public string USUARIO { get; set; }

        public DateTime? FEC_REG { get; set; }

        [StringLength(15)]
        public string USBD { get; set; }

        public DateTime? FEC_MOD { get; set; }

        public virtual TIPO_PAGO TIPO_PAGO1 { get; set; }

        public virtual PCONTRATOS PCONTRATOS { get; set; }
    }
}
