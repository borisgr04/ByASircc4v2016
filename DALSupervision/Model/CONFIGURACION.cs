namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.CONFIGURACION")]
    public partial class CONFIGURACION
    {
        [Key]
        [StringLength(20)]
        public string PROPIEDAD { get; set; }

        [StringLength(20)]
        public string VALOR { get; set; }
    }
}
