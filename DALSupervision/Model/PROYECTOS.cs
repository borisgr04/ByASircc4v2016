namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.PROYECTOS")]
    public partial class PROYECTOS
    {
        public PROYECTOS()
        {
            CPROYECTOS = new HashSet<CPROYECTOS>();
            EP_PROYECTOS = new HashSet<EP_PROYECTOS>();
            GPPROYECTOS = new HashSet<GPPROYECTOS>();
            MOD_CPROYECTOS = new HashSet<MOD_CPROYECTOS>();
        }

        [StringLength(4)]
        public string VIGENCIA { get; set; }

        [Key]
        [StringLength(30)]
        public string PROYECTO { get; set; }

        [StringLength(255)]
        public string NOMBRE_PROYECTO { get; set; }

        public DateTime? FECHA_RAD { get; set; }

        [StringLength(20)]
        public string COMITE { get; set; }

        public decimal? VALOR { get; set; }

        [StringLength(30)]
        public string ESTADO { get; set; }

        public decimal? APORTES_PROPIOS { get; set; }

        [StringLength(50)]
        public string NOM_MUN { get; set; }

        [StringLength(50)]
        public string DEP_NOM { get; set; }

        [StringLength(3)]
        public string TIP_PRO { get; set; }

        [StringLength(15)]
        public string IDE_APORTANTE { get; set; }

        public string NECESIDAD { get; set; }

        [StringLength(10)]
        public string BPIN { get; set; }

        public virtual ICollection<CPROYECTOS> CPROYECTOS { get; set; }

        public virtual ICollection<EP_PROYECTOS> EP_PROYECTOS { get; set; }

        public virtual ICollection<GPPROYECTOS> GPPROYECTOS { get; set; }

        public virtual ICollection<MOD_CPROYECTOS> MOD_CPROYECTOS { get; set; }

        public virtual PROYECTOS PROYECTOS1 { get; set; }

        public virtual PROYECTOS PROYECTOS2 { get; set; }
    }
}
