namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.TIPOSGASTOS")]
    public partial class TIPOSGASTOS
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(5)]
        public string COD_GASTO { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string DES_GASTO { get; set; }
    }
}
