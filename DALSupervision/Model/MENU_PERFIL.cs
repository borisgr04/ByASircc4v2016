namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.MENU_PERFIL")]
    public partial class MENU_PERFIL
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MENUID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string PERFIL { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(8)]
        public string MODULO { get; set; }

        [StringLength(10)]
        public string USAP { get; set; }

        [StringLength(10)]
        public string USBD { get; set; }

        public DateTime? FREG { get; set; }

        public DateTime? FNOV { get; set; }

        public virtual MENU2 MENU2 { get; set; }
    }
}
