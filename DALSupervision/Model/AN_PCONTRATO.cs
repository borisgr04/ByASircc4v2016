namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.AN_PCONTRATO")]
    public partial class AN_PCONTRATO
    {
        [Key]
        [StringLength(20)]
        public string PRO_SEL_NRO { get; set; }

        [StringLength(255)]
        public string OBSERVACION { get; set; }

        public virtual PCONTRATOS PCONTRATOS { get; set; }
    }
}
