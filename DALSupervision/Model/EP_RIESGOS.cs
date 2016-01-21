namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.EP_RIESGOS")]
    public partial class EP_RIESGOS
    {
        public decimal ID { get; set; }

        public decimal? N { get; set; }

        public decimal? ID_EP { get; set; }

        [StringLength(20)]
        public string CLASE { get; set; }

        [StringLength(10)]
        public string FUENTE { get; set; }

        [StringLength(20)]
        public string ETAPA { get; set; }

        [StringLength(50)]
        public string TIPO { get; set; }

        [StringLength(100)]
        public string DESCRIPCION { get; set; }

        [StringLength(100)]
        public string CONSECUENCIAS { get; set; }

        public bool? PROBABILIDAD_R { get; set; }

        public bool? IMPACTO_R { get; set; }

        public byte? VALORACION_R { get; set; }

        [StringLength(50)]
        public string CATEGORIA_R { get; set; }

        [StringLength(50)]
        public string AQUIENSEASIGNA { get; set; }

        [StringLength(100)]
        public string TRATAMIENTO { get; set; }

        public bool? PROBABILIDAD_T { get; set; }

        public bool? IMPACTO_T { get; set; }

        public byte? VALORACION_T { get; set; }

        [StringLength(50)]
        public string CATEGORIA_T { get; set; }

        [StringLength(2)]
        public string AFECTAEJECUCIONCTO { get; set; }

        [StringLength(100)]
        public string RESPONSABLE { get; set; }

        public DateTime? FECHAINICIO { get; set; }

        public DateTime? FECHACOMPLETA { get; set; }

        [StringLength(100)]
        public string FORMA_MONITOREO { get; set; }

        [StringLength(50)]
        public string PERIOCIDAD { get; set; }

        public virtual ESTPREV ESTPREV { get; set; }
    }
}
