namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.EP_DT_UNIDADES")]
    public partial class EP_DT_UNIDADES
    {
        public EP_DT_UNIDADES()
        {
            EP_ESPTEC = new HashSet<EP_ESPTEC>();
        }

        [Key]
        [StringLength(2)]
        public string COD_UNI { get; set; }

        [StringLength(200)]
        public string NOM_UNI { get; set; }

        public virtual ICollection<EP_ESPTEC> EP_ESPTEC { get; set; }
    }
}
