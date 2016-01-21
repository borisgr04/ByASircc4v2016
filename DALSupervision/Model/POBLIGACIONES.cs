namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.POBLIGACIONES")]
    public partial class POBLIGACIONES
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string NUM_PCON { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDE_OBLIG { get; set; }

        [StringLength(300)]
        public string DES_OBLIG { get; set; }

        public virtual PCONTRATOS PCONTRATOS { get; set; }
    }
}
