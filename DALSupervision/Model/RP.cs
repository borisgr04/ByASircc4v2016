namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.RP")]
    public partial class RP
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NRO_RP { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2)]
        public string TIP_RP { get; set; }
    }
}
