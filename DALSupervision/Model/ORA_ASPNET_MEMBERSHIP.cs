namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.ORA_ASPNET_MEMBERSHIP")]
    public partial class ORA_ASPNET_MEMBERSHIP
    {
        public Guid APPLICATIONID { get; set; }

        [Key]
        public Guid USERID { get; set; }

        [Required]
        [StringLength(128)]
        public string PASSWORD { get; set; }

        public decimal PASSWORDFORMAT { get; set; }

        [Required]
        [StringLength(128)]
        public string PASSWORDSALT { get; set; }

        [StringLength(16)]
        public string MOBILEPIN { get; set; }

        [StringLength(256)]
        public string EMAIL { get; set; }

        [StringLength(256)]
        public string LOWEREDEMAIL { get; set; }

        [StringLength(256)]
        public string PASSWORDQUESTION { get; set; }

        [StringLength(128)]
        public string PASSWORDANSWER { get; set; }

        public decimal ISAPPROVED { get; set; }

        public decimal ISLOCKEDOUT { get; set; }

        public DateTime CREATEDATE { get; set; }

        public DateTime LASTLOGINDATE { get; set; }

        public DateTime LASTPASSWORDCHANGEDDATE { get; set; }

        public DateTime LASTLOCKOUTDATE { get; set; }

        public decimal FAILEDPWDATTEMPTCOUNT { get; set; }

        public DateTime FAILEDPWDATTEMPTWINSTART { get; set; }

        public decimal FAILEDPWDANSWERATTEMPTCOUNT { get; set; }

        public DateTime FAILEDPWDANSWERATTEMPTWINSTART { get; set; }

        public string COMMENTS { get; set; }

        public virtual ORA_ASPNET_APPLICATIONS ORA_ASPNET_APPLICATIONS { get; set; }

        public virtual ORA_ASPNET_USERS ORA_ASPNET_USERS { get; set; }
    }
}
