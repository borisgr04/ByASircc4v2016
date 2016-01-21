namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.MOD_TIP_PLA")]
    public partial class MOD_TIP_PLA
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(5)]
        public string COD_MOD { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2)]
        public string COD_TIP { get; set; }

        [StringLength(2)]
        public string EST { get; set; }

        public virtual TIPOSPROC TIPOSPROC { get; set; }

        public virtual PL_TIPOS_PLANTILLA PL_TIPOS_PLANTILLA { get; set; }
    }
}
