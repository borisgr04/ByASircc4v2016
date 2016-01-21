namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.TIPO_INTERVENTOR")]
    public partial class TIPO_INTERVENTOR
    {
        public decimal ID { get; set; }

        [StringLength(1)]
        public string COD_TIP { get; set; }

        [StringLength(30)]
        public string NOM_TIP { get; set; }
    }
}
