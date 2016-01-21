namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.EP_OBLIGACIONESE")]
    public partial class EP_OBLIGACIONESE
    {
        public decimal ID { get; set; }

        public decimal? ID_EP { get; set; }

        public string DES_OBLIG { get; set; }

        public decimal? GRUPO { get; set; }

        public virtual ESTPREV ESTPREV { get; set; }
    }
}
