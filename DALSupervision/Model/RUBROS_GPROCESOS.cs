namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.RUBROS_GPROCESOS")]
    public partial class RUBROS_GPROCESOS
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string COD_RUB { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string NUM_PRO { get; set; }

        public decimal? VALOR { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string NRO_CDP { get; set; }

        [StringLength(4)]
        public string VIGENCIA_CDP { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GRUPO { get; set; }

        public virtual GPROCESOS GPROCESOS { get; set; }
    }
}
