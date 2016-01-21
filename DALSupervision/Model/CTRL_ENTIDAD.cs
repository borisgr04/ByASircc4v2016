namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.CTRL_ENTIDAD")]
    public partial class CTRL_ENTIDAD
    {
        [StringLength(6)]
        public string COD_SECPRINCIPAL { get; set; }

        [StringLength(100)]
        public string NOM_SECPRINCIPAL { get; set; }

        [Key]
        [StringLength(20)]
        public string NIT { get; set; }

        [StringLength(80)]
        public string REPRESENTANTE_LEGAL { get; set; }

        [StringLength(80)]
        public string TELEFONO { get; set; }

        [StringLength(40)]
        public string FAX { get; set; }

        [StringLength(80)]
        public string EMAIL { get; set; }

        [StringLength(80)]
        public string DIRECCION { get; set; }

        [StringLength(80)]
        public string PAIS { get; set; }

        [StringLength(80)]
        public string DEPARTAMENTO { get; set; }

        [StringLength(80)]
        public string CIUDAD { get; set; }

        [StringLength(80)]
        public string MUNICIPIO { get; set; }

        public byte[] LOGO_RPT { get; set; }
    }
}
