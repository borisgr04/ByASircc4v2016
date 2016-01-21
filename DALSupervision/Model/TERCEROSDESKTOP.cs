namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.TERCEROSDESKTOP")]
    public partial class TERCEROSDESKTOP
    {
        [Key]
        [StringLength(20)]
        public string USUARIO { get; set; }

        [StringLength(100)]
        public string ADMINISTRADOR { get; set; }
    }
}
