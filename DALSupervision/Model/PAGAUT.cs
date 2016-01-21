namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.PAGAUT")]
    public partial class PAGAUT
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MENUID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string NOMPAG { get; set; }
    }
}
