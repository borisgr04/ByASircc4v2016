namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.ORA_ASPNET_USERS")]
    public partial class ORA_ASPNET_USERS
    {
        public ORA_ASPNET_USERS()
        {
            ORA_ASPNET_PERSONALIZNPERUSER = new HashSet<ORA_ASPNET_PERSONALIZNPERUSER>();
            ORA_ASPNET_ROLES = new HashSet<ORA_ASPNET_ROLES>();
        }

        public Guid APPLICATIONID { get; set; }

        [Key]
        public Guid USERID { get; set; }

        [Required]
        [StringLength(256)]
        public string USERNAME { get; set; }

        [Required]
        [StringLength(256)]
        public string LOWEREDUSERNAME { get; set; }

        [StringLength(16)]
        public string MOBILEALIAS { get; set; }

        public decimal ISANONYMOUS { get; set; }

        public DateTime LASTACTIVITYDATE { get; set; }

        public virtual ORA_ASPNET_APPLICATIONS ORA_ASPNET_APPLICATIONS { get; set; }

        public virtual ORA_ASPNET_MEMBERSHIP ORA_ASPNET_MEMBERSHIP { get; set; }

        public virtual ICollection<ORA_ASPNET_PERSONALIZNPERUSER> ORA_ASPNET_PERSONALIZNPERUSER { get; set; }

        public virtual ORA_ASPNET_PROFILE ORA_ASPNET_PROFILE { get; set; }

        public virtual ICollection<ORA_ASPNET_ROLES> ORA_ASPNET_ROLES { get; set; }
    }
}
