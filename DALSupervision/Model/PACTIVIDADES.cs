namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.PACTIVIDADES")]
    public partial class PACTIVIDADES
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(4)]
        public string COD_ACT { get; set; }

        [StringLength(1000)]
        public string NOM_ACT { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string COD_TPRO { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(4)]
        public string VIGENCIA { get; set; }

        public decimal? ORDEN { get; set; }

        [StringLength(2)]
        public string OCUPADO { get; set; }

        [StringLength(2)]
        public string EST_PROC { get; set; }

        [StringLength(2)]
        public string ESTADO { get; set; }

        [StringLength(2)]
        public string OBLIGATORIO { get; set; }

        [StringLength(2)]
        public string DIA_NOHABIL { get; set; }

        [StringLength(2)]
        public string NOTIFICAR { get; set; }

        [StringLength(2)]
        public string MFECINI { get; set; }

        [StringLength(2)]
        public string MHORINI { get; set; }

        [StringLength(2)]
        public string MFECFIN { get; set; }

        [StringLength(2)]
        public string MHORFIN { get; set; }

        [StringLength(1000)]
        public string UBICACION { get; set; }

        [StringLength(2)]
        public string TIPO { get; set; }

        [StringLength(2)]
        public string TIP_PLA { get; set; }

        public virtual PL_TIPOS_PLANTILLA PL_TIPOS_PLANTILLA { get; set; }

        public virtual TIPOSPROC TIPOSPROC { get; set; }

        public virtual PESTADOS PESTADOS { get; set; }
    }
}
