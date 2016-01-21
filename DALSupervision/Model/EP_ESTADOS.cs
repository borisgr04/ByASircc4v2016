namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.EP_ESTADOS")]
    public partial class EP_ESTADOS
    {
        public EP_ESTADOS()
        {
            ESTPREV = new HashSet<ESTPREV>();
        }

        [Key]
        [StringLength(2)]
        public string COD_EST { get; set; }

        [StringLength(20)]
        public string NOM_EST { get; set; }

        public virtual ICollection<ESTPREV> ESTPREV { get; set; }
    }
}
