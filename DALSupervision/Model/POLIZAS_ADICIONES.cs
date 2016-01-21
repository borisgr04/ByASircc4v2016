namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.POLIZAS_ADICIONES")]
    public partial class POLIZAS_ADICIONES
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string NRO_ADI { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int COD_POL { get; set; }

        public int COD_ASE { get; set; }

        public int VAL_POL { get; set; }

        public DateTime FEC_POL { get; set; }

        public decimal NRO_POL { get; set; }

        public virtual ASEGURADORAS ASEGURADORAS { get; set; }

        public virtual POLIZAS POLIZAS { get; set; }
    }
}
