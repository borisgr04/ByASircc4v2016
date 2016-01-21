namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.PL_SECCIONES")]
    public partial class PL_SECCIONES
    {
        public decimal ID { get; set; }

        public decimal? ID_PLA { get; set; }

        public string HTML { get; set; }

        public virtual PL_PLANTILLA PL_PLANTILLA { get; set; }
    }
}
