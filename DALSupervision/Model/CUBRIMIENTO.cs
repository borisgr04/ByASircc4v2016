namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.CUBRIMIENTO")]
    public partial class CUBRIMIENTO
    {
        [Key]
        [StringLength(2)]
        public string COD_CUB { get; set; }

        [StringLength(100)]
        public string NOM_CUB { get; set; }
    }
}
