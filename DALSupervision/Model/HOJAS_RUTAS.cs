namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.HOJAS_RUTAS")]
    public partial class HOJAS_RUTAS
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(4)]
        public string COD_HRUTA { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2)]
        public string COD_ETAPA { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(2)]
        public string COD_TDOC { get; set; }

        [Required]
        [StringLength(1)]
        public string DOC_OBLIG { get; set; }

        [Required]
        [StringLength(2)]
        public string DOC_EST { get; set; }
    }
}
