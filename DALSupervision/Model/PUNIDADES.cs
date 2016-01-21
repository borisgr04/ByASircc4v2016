namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.PUNIDADES")]
    public partial class PUNIDADES
    {
        [Key]
        [StringLength(2)]
        public string COD_UNIDAD { get; set; }

        [StringLength(30)]
        public string NOM_UNIDAD { get; set; }
    }
}
