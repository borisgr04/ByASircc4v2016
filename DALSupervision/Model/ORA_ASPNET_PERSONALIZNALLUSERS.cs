namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.ORA_ASPNET_PERSONALIZNALLUSERS")]
    public partial class ORA_ASPNET_PERSONALIZNALLUSERS
    {
        public Guid? PATHID { get; set; }

        [Key]
        [Column(Order = 0)]
        public byte[] PAGESETTINGS { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime LASTUPDATEDDATE { get; set; }

        public virtual ORA_ASPNET_PATHS ORA_ASPNET_PATHS { get; set; }
    }
}
