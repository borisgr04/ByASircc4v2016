namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.EP_CONMUN")]
    public partial class EP_CONMUN
    {
        public decimal ID { get; set; }

        public decimal? ID_EP { get; set; }

        [Required]
        [StringLength(5)]
        public string COD_MUN { get; set; }

        public virtual ESTPREV ESTPREV { get; set; }

        public virtual MUNICIPIOS MUNICIPIOS { get; set; }
    }
}
