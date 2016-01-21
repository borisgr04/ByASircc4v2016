namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.DOC_SECCIONES")]
    public partial class DOC_SECCIONES
    {
        public decimal ID { get; set; }

        public decimal? ID_DOC { get; set; }

        public string HTML { get; set; }

        public string CRUZADO { get; set; }

        public virtual DOC_PLANTILLA DOC_PLANTILLA { get; set; }
    }
}
