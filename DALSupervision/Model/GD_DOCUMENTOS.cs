namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.GD_DOCUMENTOS")]
    public partial class GD_DOCUMENTOS
    {
        public decimal ID { get; set; }

        [StringLength(255)]
        public string NOMBRE { get; set; }

        public decimal? LONGITUD { get; set; }

        [StringLength(255)]
        public string TYPE { get; set; }

        [StringLength(255)]
        public string URL { get; set; }

        [StringLength(1000)]
        public string DESCRIPCION { get; set; }

        [StringLength(20)]
        public string USUARIO { get; set; }

        public DateTime? FEC_REG { get; set; }

        public DateTime? FEC_MOD { get; set; }

        [StringLength(2)]
        public string ESTADO { get; set; }

        public virtual GD_DDOCUMENTOS GD_DDOCUMENTOS { get; set; }
    }
}
