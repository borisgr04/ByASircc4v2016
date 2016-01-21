namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.RUBROS")]
    public partial class RUBROS
    {
        public RUBROS()
        {
            C_RUBROS_CDP = new HashSet<C_RUBROS_CDP>();
            EP_RUBROS_CDP = new HashSet<EP_RUBROS_CDP>();
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string COD_RUB { get; set; }

        [StringLength(400)]
        public string DES_RUB { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short VIGENCIA { get; set; }

        [StringLength(50)]
        public string COD_UNIDAD { get; set; }

        [StringLength(4)]
        public string COD_RECURSO { get; set; }

        [StringLength(4)]
        public string CLASE { get; set; }

        public virtual ICollection<C_RUBROS_CDP> C_RUBROS_CDP { get; set; }

        public virtual ICollection<EP_RUBROS_CDP> EP_RUBROS_CDP { get; set; }
    }
}
