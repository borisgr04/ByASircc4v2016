namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.MENUMB")]
    public partial class MENUMB
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MENUID { get; set; }

        [StringLength(20)]
        public string TITULO { get; set; }

        [StringLength(50)]
        public string DESCRIPCION { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string MODULOMB { get; set; }

        [StringLength(10)]
        public string PADREID { get; set; }

        [StringLength(2)]
        public string ESTADO { get; set; }

        [StringLength(200)]
        public string URL { get; set; }
    }
}
