namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.MENU2")]
    public partial class MENU2
    {
        public MENU2()
        {
            MENU_PERFIL = new HashSet<MENU_PERFIL>();
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MENUID { get; set; }

        [Required]
        [StringLength(32)]
        public string TITULO { get; set; }

        [Required]
        [StringLength(50)]
        public string DESCRIPCION { get; set; }

        [Required]
        [StringLength(10)]
        public string PADREID { get; set; }

        public int POSICION { get; set; }

        [StringLength(200)]
        public string ICONO { get; set; }

        public bool HABILITADO { get; set; }

        [StringLength(100)]
        public string URL { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MODULO { get; set; }

        [StringLength(512)]
        public string ROLES { get; set; }

        [StringLength(20)]
        public string TARGET { get; set; }

        [StringLength(1)]
        public string PPAL { get; set; }

        [StringLength(10)]
        public string USAP { get; set; }

        [StringLength(10)]
        public string USBD { get; set; }

        public DateTime? FREG { get; set; }

        public DateTime? FNOV { get; set; }

        public virtual ICollection<MENU_PERFIL> MENU_PERFIL { get; set; }

        public virtual MENU2 MENU21 { get; set; }

        public virtual MENU2 MENU22 { get; set; }
    }
}
