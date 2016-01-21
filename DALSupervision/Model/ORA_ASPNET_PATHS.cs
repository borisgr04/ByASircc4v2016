namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.ORA_ASPNET_PATHS")]
    public partial class ORA_ASPNET_PATHS
    {
        public ORA_ASPNET_PATHS()
        {
            ORA_ASPNET_PERSONALIZNALLUSERS = new HashSet<ORA_ASPNET_PERSONALIZNALLUSERS>();
            ORA_ASPNET_PERSONALIZNPERUSER = new HashSet<ORA_ASPNET_PERSONALIZNPERUSER>();
        }

        public Guid APPLICATIONID { get; set; }

        [Key]
        public Guid PATHID { get; set; }

        [Required]
        [StringLength(256)]
        public string PATH { get; set; }

        [Required]
        [StringLength(256)]
        public string LOWEREDPATH { get; set; }

        public virtual ORA_ASPNET_APPLICATIONS ORA_ASPNET_APPLICATIONS { get; set; }

        public virtual ICollection<ORA_ASPNET_PERSONALIZNALLUSERS> ORA_ASPNET_PERSONALIZNALLUSERS { get; set; }

        public virtual ICollection<ORA_ASPNET_PERSONALIZNPERUSER> ORA_ASPNET_PERSONALIZNPERUSER { get; set; }
    }
}
