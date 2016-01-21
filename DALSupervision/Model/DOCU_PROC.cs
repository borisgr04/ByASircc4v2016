namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.DOCU_PROC")]
    public partial class DOCU_PROC
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string COD_TPROC { get; set; }

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
