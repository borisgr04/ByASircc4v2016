namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.CMINUTAS")]
    public partial class CMINUTAS
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string CMIN_CODI { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string CMIN_NOMB { get; set; }

        [Key]
        [Column(Order = 2)]
        public string CMIN_ENCA { get; set; }

        public string CMIN_BODY { get; set; }

        public string CMIN_PIEP { get; set; }

        [StringLength(200)]
        public string CMIN_CAMP { get; set; }

        [StringLength(20)]
        public string CMIN_VISTA { get; set; }

        [StringLength(10)]
        public string CMIN_USBD { get; set; }

        [StringLength(10)]
        public string CMIN_USAP { get; set; }

        [StringLength(2)]
        public string CMIN_ESTA { get; set; }

        public DateTime? CMIN_FREG { get; set; }

        public DateTime? CMIN_FNOV { get; set; }
    }
}
