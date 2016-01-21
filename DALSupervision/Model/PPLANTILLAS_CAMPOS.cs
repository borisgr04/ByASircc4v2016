namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.PPLANTILLAS_CAMPOS")]
    public partial class PPLANTILLAS_CAMPOS
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string NOM_CAM { get; set; }

        [StringLength(50)]
        public string NOM_PLA { get; set; }

        [StringLength(100)]
        public string DES_CAM { get; set; }

        [StringLength(2)]
        public string TIP_DAT { get; set; }

        [StringLength(2)]
        public string EST_CAM { get; set; }

        [StringLength(1)]
        public string GTABLA { get; set; }

        [StringLength(50)]
        public string NTABLA { get; set; }

        [StringLength(2)]
        public string ENCABEZADO_PIE { get; set; }

        [StringLength(2)]
        public string MOSTRAR_TITULOS { get; set; }

        [StringLength(2)]
        public string MOSTRAR_BORDE { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string VISTA { get; set; }

        [StringLength(2)]
        public string MARCADOR { get; set; }

        public decimal? IDE_PLA { get; set; }

        public decimal? COL_FINAL { get; set; }

        [StringLength(1)]
        public string TAGRUPADA { get; set; }

        [StringLength(50)]
        public string COLS_GRUPO { get; set; }
    }
}
