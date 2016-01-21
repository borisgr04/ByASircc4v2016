namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.PCRONO_DIAS")]
    public partial class PCRONO_DIAS
    {
        [Key]
        [Column(Order = 0)]
        public decimal ID_CRONO { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime FECHA { get; set; }

        public DateTime? FEC_REG { get; set; }

        [StringLength(20)]
        public string USAP { get; set; }

        [StringLength(20)]
        public string USBD { get; set; }

        public virtual PCRONOGRAMAS PCRONOGRAMAS { get; set; }
    }
}
