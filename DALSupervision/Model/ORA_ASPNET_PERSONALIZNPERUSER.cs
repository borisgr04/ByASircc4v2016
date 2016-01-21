namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.ORA_ASPNET_PERSONALIZNPERUSER")]
    public partial class ORA_ASPNET_PERSONALIZNPERUSER
    {
        public Guid ID { get; set; }

        public Guid? PATHID { get; set; }

        public Guid? USERID { get; set; }

        [Required]
        public byte[] PAGESETTINGS { get; set; }

        public DateTime LASTUPDATEDDATE { get; set; }

        public virtual ORA_ASPNET_PATHS ORA_ASPNET_PATHS { get; set; }

        public virtual ORA_ASPNET_USERS ORA_ASPNET_USERS { get; set; }
    }
}
