namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.RP_CONTRATOS_A")]
    public partial class RP_CONTRATOS_A
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string NRO_RP { get; set; }

        [StringLength(10)]
        public string COD_CON { get; set; }

        [StringLength(15)]
        public string NRO_ADI { get; set; }

        public DateTime FEC_RP { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short VIGENCIA { get; set; }
    }
}
