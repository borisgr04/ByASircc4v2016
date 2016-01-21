namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.CONS_PROC")]
    public partial class CONS_PROC
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string DEP_DEL { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string TIP_PROC { get; set; }

        public decimal? INICIAL { get; set; }

        public decimal? SIGUIENTE { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short VIGENCIA { get; set; }

        public virtual DEPENDENCIA DEPENDENCIA { get; set; }

        public virtual TIPOSPROC TIPOSPROC { get; set; }
    }
}
