namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.HORAS")]
    public partial class HORAS
    {
        [Key]
        public decimal COD_HOR { get; set; }

        [Required]
        [StringLength(20)]
        public string NOM_HOR { get; set; }

        [Required]
        [StringLength(4)]
        public string JOR_HOR { get; set; }

        [StringLength(20)]
        public string NOM_HMIL { get; set; }

        [StringLength(1)]
        public string LABORALES { get; set; }
    }
}
