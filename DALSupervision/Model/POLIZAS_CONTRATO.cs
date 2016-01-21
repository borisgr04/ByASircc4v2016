namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.POLIZAS_CONTRATO")]
    public partial class POLIZAS_CONTRATO
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string COD_CON { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int COD_POL { get; set; }

        public int COD_ASE { get; set; }

        public decimal VAL_POL { get; set; }

        public DateTime FEC_POL { get; set; }

        [StringLength(30)]
        public string NRO_POL { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_POL { get; set; }

        [StringLength(1)]
        public string TIP_POL { get; set; }

        [StringLength(30)]
        public string NRO_POL_AUX { get; set; }

        public DateTime? FEC_INI { get; set; }

        public virtual ASEGURADORAS ASEGURADORAS { get; set; }

        public virtual POLIZAS POLIZAS { get; set; }
    }
}
