namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.ORA_ASPNET_PROFILE")]
    public partial class ORA_ASPNET_PROFILE
    {
        [Key]
        public Guid USERID { get; set; }

        [Required]
        public string PROPERTYNAMES { get; set; }

        [Required]
        public string PROPERTYVALUESSTRING { get; set; }

        [Required]
        public byte[] PROPERTYVALUESBINARY { get; set; }

        public DateTime LASTUPDATEDDATE { get; set; }

        public virtual ORA_ASPNET_USERS ORA_ASPNET_USERS { get; set; }
    }
}
