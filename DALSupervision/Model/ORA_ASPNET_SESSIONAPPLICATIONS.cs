namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.ORA_ASPNET_SESSIONAPPLICATIONS")]
    public partial class ORA_ASPNET_SESSIONAPPLICATIONS
    {
        [Key]
        public Guid APPID { get; set; }

        [Required]
        [StringLength(280)]
        public string APPNAME { get; set; }
    }
}
