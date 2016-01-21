namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.PPLANTILLAS_FORMATO_TABLAS")]
    public partial class PPLANTILLAS_FORMATO_TABLAS
    {
        [Key]
        [Column(Order = 0)]
        public decimal IDE_PLA { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string NTABLA { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string NOM_CAM { get; set; }

        [StringLength(100)]
        public string DES_CAM { get; set; }

        [StringLength(2)]
        public string TIP_DAT { get; set; }

        public decimal? ANCHO { get; set; }

        public virtual PPLANTILLAS PPLANTILLAS { get; set; }
    }
}
