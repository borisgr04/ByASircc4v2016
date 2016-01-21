namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.EP_UNSPSC")]
    public partial class EP_UNSPSC
    {
        public decimal ID { get; set; }

        public decimal? ID_EP { get; set; }

        [StringLength(8)]
        public string UNSPSC { get; set; }

        public virtual EP_CODIGOSUNSPSC EP_CODIGOSUNSPSC { get; set; }

        public virtual ESTPREV ESTPREV { get; set; }
    }
}
