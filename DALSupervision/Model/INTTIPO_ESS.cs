namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.INTTIPO_ESS")]
    public partial class INTTIPO_ESS
    {
        [Key]
        [StringLength(2)]
        public string COD_TIP { get; set; }

        [Required]
        [StringLength(30)]
        public string NOM_TIP { get; set; }

        [StringLength(2)]
        public string EST_TIP { get; set; }
    }
}
