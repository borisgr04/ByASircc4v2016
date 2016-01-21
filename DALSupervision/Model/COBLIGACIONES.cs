namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.COBLIGACIONES")]
    public partial class COBLIGACIONES
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(15)]
        public string COD_CON { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDE_OBLIG { get; set; }

        [StringLength(4000)]
        public string DES_OBLIG2 { get; set; }

        public string DES_OBLIG { get; set; }
    }
}
