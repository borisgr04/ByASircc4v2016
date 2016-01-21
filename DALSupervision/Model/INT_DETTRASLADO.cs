namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.INT_DETTRASLADO")]
    public partial class INT_DETTRASLADO
    {
        public decimal ID { get; set; }

        public decimal? ID_TRASLADO { get; set; }

        public decimal? ID_CTRDOC { get; set; }

        [StringLength(2)]
        public string EST_TRA { get; set; }

        public decimal? ID_CTRDOC2 { get; set; }

        public virtual INT_CONTROL_DOC INT_CONTROL_DOC { get; set; }

        public virtual INT_CONTROL_DOC INT_CONTROL_DOC1 { get; set; }

        public virtual INT_TRASLADOS INT_TRASLADOS { get; set; }
    }
}
