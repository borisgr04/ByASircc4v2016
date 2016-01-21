namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.ORA_ASPNET_SESSIONS")]
    public partial class ORA_ASPNET_SESSIONS
    {
        [Key]
        [StringLength(116)]
        public string SESSIONID { get; set; }

        public DateTime CREATED { get; set; }

        public DateTime EXPIRES { get; set; }

        public DateTime LOCKDATE { get; set; }

        public DateTime LOCKDATELOCAL { get; set; }

        public decimal LOCKCOOKIE { get; set; }

        public decimal TIMEOUT { get; set; }

        public decimal LOCKED { get; set; }

        [MaxLength(2000)]
        public byte[] SESSIONITEMSHORT { get; set; }

        public byte[] SESSIONITEMLONG { get; set; }

        public decimal FLAGS { get; set; }
    }
}
