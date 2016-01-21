namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.MENU")]
    public partial class MENU
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MENUID { get; set; }

        [Required]
        [StringLength(30)]
        public string DESCRIPCION { get; set; }

        [Required]
        [StringLength(10)]
        public string PADREID { get; set; }

        public int POSICION { get; set; }

        [StringLength(30)]
        public string ICONO { get; set; }

        public bool HABILITADO { get; set; }

        [StringLength(100)]
        public string URL { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string PERFIL { get; set; }
    }
}
