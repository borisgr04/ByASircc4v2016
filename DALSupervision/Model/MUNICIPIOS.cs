namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.MUNICIPIOS")]
    public partial class MUNICIPIOS
    {
        public MUNICIPIOS()
        {
            EP_CONMUN = new HashSet<EP_CONMUN>();
        }

        [Key]
        [StringLength(10)]
        public string COD_MUN { get; set; }

        [Required]
        [StringLength(100)]
        public string NOM_MUN { get; set; }

        public virtual ICollection<EP_CONMUN> EP_CONMUN { get; set; }
    }
}
