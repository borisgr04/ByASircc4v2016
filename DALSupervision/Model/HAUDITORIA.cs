namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.HAUDITORIA")]
    public partial class HAUDITORIA
    {
        [Key]
        [Column(Order = 0)]
        public decimal HAUDCODI { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string HAUDTABL { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string HAUDIDEN { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(20)]
        public string HAUDTIPO { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(2000)]
        public string HAUDDESC { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(30)]
        public string HAUDUSER { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime HAUDFESI { get; set; }

        [StringLength(10)]
        public string HAUDUSBD { get; set; }
    }
}
