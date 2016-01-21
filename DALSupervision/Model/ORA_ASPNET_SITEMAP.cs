namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.ORA_ASPNET_SITEMAP")]
    public partial class ORA_ASPNET_SITEMAP
    {
        [Key]
        [Column(Order = 0)]
        public Guid APPLICATIONID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(32)]
        public string TITLE { get; set; }

        [StringLength(512)]
        public string DESCRIPTION { get; set; }

        [StringLength(512)]
        public string URL { get; set; }

        [StringLength(512)]
        public string ROLES { get; set; }

        public int? PARENT { get; set; }

        public virtual ORA_ASPNET_APPLICATIONS ORA_ASPNET_APPLICATIONS { get; set; }
    }
}
