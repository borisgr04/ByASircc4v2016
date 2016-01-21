namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.AUDI_CONTRATOS")]
    public partial class AUDI_CONTRATOS
    {
        [StringLength(100)]
        public string TABLA { get; set; }

        [StringLength(20)]
        public string COD_CON { get; set; }

        [StringLength(20)]
        public string CAMPO { get; set; }

        [StringLength(4000)]
        public string VALOR_ANTERIOR { get; set; }

        [StringLength(4000)]
        public string VALOR_NUEVO { get; set; }

        public DateTime? FECHA_REG { get; set; }

        [StringLength(20)]
        public string USBD { get; set; }

        [StringLength(20)]
        public string USAP { get; set; }

        [Key]
        public decimal ID_AUDICON { get; set; }
    }
}
