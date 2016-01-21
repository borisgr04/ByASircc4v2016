namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.CONSORCIOSUT")]
    public partial class CONSORCIOSUT
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(15)]
        public string IDE_TER { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(15)]
        public string ID_MIEMBROS { get; set; }

        [StringLength(2)]
        public string ID_ESTADO { get; set; }

        public decimal? PORC_PART { get; set; }

        public virtual TERCEROS TERCEROS { get; set; }
    }
}
