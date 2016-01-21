namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.MOD_COBLIGACIONES")]
    public partial class MOD_COBLIGACIONES
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(15)]
        public string NUM_SOL_ADI { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(15)]
        public string COD_CON { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDE_OBLIG { get; set; }

        [StringLength(4000)]
        public string DES_OBLIG2 { get; set; }

        public string DES_OBLIG { get; set; }

        public DateTime? FEC_REG { get; set; }

        [StringLength(20)]
        public string USBD { get; set; }

        [StringLength(20)]
        public string USAP { get; set; }

        public virtual SOL_ADICIONES SOL_ADICIONES { get; set; }
    }
}
