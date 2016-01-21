namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.EP_PROYECTOS")]
    public partial class EP_PROYECTOS
    {
        [Key]
        [Column(Order = 0)]
        public decimal ID_EP { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string COD_PRO { get; set; }

        public DateTime? FEC_REG { get; set; }

        [StringLength(12)]
        public string USAP_REG { get; set; }

        public DateTime? FEC_MOD { get; set; }

        [StringLength(12)]
        public string USAP_MOD { get; set; }

        public virtual ESTPREV ESTPREV { get; set; }

        public virtual PROYECTOS PROYECTOS { get; set; }
    }
}
