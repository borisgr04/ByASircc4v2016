namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.EP_ESTFLU")]
    public partial class EP_ESTFLU
    {
        public EP_ESTFLU()
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
