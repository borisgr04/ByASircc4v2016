namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.ORA_ASPNET_APPLICATIONS")]
    public partial class ORA_ASPNET_APPLICATIONS
    {
        public ORA_ASPNET_APPLICATIONS()
        {
            ORA_ASPNET_ROLES = new HashSet<ORA_ASPNET_ROLES>();
            ORA_ASPNET_MEMBERSHIP = new HashSet<ORA_ASPNET_MEMBERSHIP>();
            ORA_ASPNET_PATHS = new HashSet<ORA_ASPNET_PATHS>();
            ORA_ASPNET_SITEMAP = new HashSet<ORA_ASPNET_SITEMAP>();
            ORA_ASPNET_USERS = new HashSet<ORA_ASPNET_USERS>();
        }

        [Required]
        [StringLength(256)]
        public string APPLICATIONNAME { get; set; }

        [Required]
        [StringLength(256)]
        public string LOWEREDAPPLICATIONNAME { get; set; }

        [Key]
        public Guid APPLICATIONID { get; set; }

        [StringLength(256)]
        public string DESCRIPTION { get; set; }

        public virtual ICollection<ORA_ASPNET_ROLES> ORA_ASPNET_ROLES { get; set; }

        public virtual ICollection<ORA_ASPNET_MEMBERSHIP> ORA_ASPNET_MEMBERSHIP { get; set; }

        public virtual ICollection<ORA_ASPNET_PATHS> ORA_ASPNET_PATHS { get; set; }

        public virtual ICollection<ORA_ASPNET_SITEMAP> ORA_ASPNET_SITEMAP { get; set; }

        public virtual ICollection<ORA_ASPNET_USERS> ORA_ASPNET_USERS { get; set; }
    }
}
