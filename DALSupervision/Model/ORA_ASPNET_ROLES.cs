namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.ORA_ASPNET_ROLES")]
    public partial class ORA_ASPNET_ROLES
    {
        public ORA_ASPNET_ROLES()
        {
            ORA_ASPNET_USERS = new HashSet<ORA_ASPNET_USERS>();
        }

        public Guid APPLICATIONID { get; set; }

        [Key]
        public Guid ROLEID { get; set; }

        [Required]
        [StringLength(256)]
        public string ROLENAME { get; set; }

        [Required]
        [StringLength(256)]
        public string LOWEREDROLENAME { get; set; }

        [StringLength(256)]
        public string DESCRIPTION { get; set; }

        public virtual ORA_ASPNET_APPLICATIONS ORA_ASPNET_APPLICATIONS { get; set; }

        public virtual ICollection<ORA_ASPNET_USERS> ORA_ASPNET_USERS { get; set; }
    }
}
