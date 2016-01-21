namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.ETAPAS")]
    public partial class ETAPAS
    {
        public ETAPAS()
        {
            TIP_DOC = new HashSet<TIP_DOC>();
        }

        [Key]
        [StringLength(2)]
        public string COD_ETA { get; set; }

        [Required]
        [StringLength(100)]
        public string NOM_ETA { get; set; }

        [Required]
        [StringLength(2)]
        public string ESTADO { get; set; }

        [StringLength(2)]
        public string PROCESO { get; set; }

        public virtual ICollection<TIP_DOC> TIP_DOC { get; set; }
    }
}
