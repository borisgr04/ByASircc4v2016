namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.CORREOSE")]
    public partial class CORREOSE
    {
        [Key]
        [StringLength(10)]
        public string CORR_CODI { get; set; }

        [Required]
        [StringLength(30)]
        public string CORR_NOMB { get; set; }

        [Required]
        [StringLength(20)]
        public string CORR_DATO { get; set; }

        public string CORR_BODY { get; set; }

        [StringLength(2)]
        public string CORR_ESTA { get; set; }

        [StringLength(10)]
        public string CORR_USAP { get; set; }

        [StringLength(10)]
        public string CORR_USBD { get; set; }

        public DateTime? CORR_FREG { get; set; }

        public DateTime? CORR_FNOV { get; set; }

        [StringLength(200)]
        public string CORR_CAMP { get; set; }

        [StringLength(20)]
        public string CORR_VISTA { get; set; }
    }
}
