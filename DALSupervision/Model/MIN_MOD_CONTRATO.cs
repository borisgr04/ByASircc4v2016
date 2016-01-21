namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.MIN_MOD_CONTRATO")]
    public partial class MIN_MOD_CONTRATO
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(15)]
        public string NUM_SOL_ADI { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(500)]
        public string CAMPO { get; set; }

        [StringLength(500)]
        public string VALOR_NUEVO { get; set; }

        [StringLength(500)]
        public string VALOR_ANTERIOR { get; set; }

        [StringLength(15)]
        public string USBD { get; set; }

        [StringLength(15)]
        public string USAP { get; set; }

        public DateTime? FECMOD { get; set; }

        public DateTime? FECREG { get; set; }

        public virtual SOL_ADICIONES SOL_ADICIONES { get; set; }
    }
}
