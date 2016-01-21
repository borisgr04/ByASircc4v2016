namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.ESTADOSGENERALES")]
    public partial class ESTADOSGENERALES
    {
        [Key]
        [StringLength(2)]
        public string COD_EST { get; set; }

        [StringLength(100)]
        public string NOM_EST { get; set; }
    }
}
