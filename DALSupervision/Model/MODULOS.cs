namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.MODULOS")]
    public partial class MODULOS
    {
        [Key]
        [StringLength(4)]
        public string COD_MOD { get; set; }

        [StringLength(40)]
        public string NOM_MOD { get; set; }

        public decimal? ORD_MOD { get; set; }

        [StringLength(2)]
        public string EST_MOD { get; set; }

        [StringLength(300)]
        public string DES_MOD { get; set; }
    }
}
