namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.TIPO_AGENT")]
    public partial class TIPO_AGENT
    {
        [Key]
        [StringLength(3)]
        public string TAG_COD { get; set; }

        [Required]
        [StringLength(100)]
        public string TAG_NOM { get; set; }

        [Required]
        [StringLength(2)]
        public string TAG_EST { get; set; }

        [StringLength(10)]
        public string TAG_USAP { get; set; }

        [StringLength(10)]
        public string TAG_USBD { get; set; }

        public DateTime? TAG_FREG { get; set; }

        public DateTime? TAG_FNOV { get; set; }

        public decimal? TAG_ORD { get; set; }
    }
}
