namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.CAL_VIG_POL")]
    public partial class CAL_VIG_POL
    {
        public CAL_VIG_POL()
        {
            EP_POLIZAS = new HashSet<EP_POLIZAS>();
            PPOLIZAS = new HashSet<PPOLIZAS>();
        }

        [Key]
        [StringLength(5)]
        public string COD_CAL { get; set; }

        [StringLength(500)]
        public string DESCRIPCION { get; set; }

        public virtual ICollection<EP_POLIZAS> EP_POLIZAS { get; set; }

        public virtual ICollection<PPOLIZAS> PPOLIZAS { get; set; }
    }
}
