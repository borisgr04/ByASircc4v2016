namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.PGCONTRATOSM")]
    public partial class PGCONTRATOSM
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string NUM_PROC { get; set; }

        public byte[] MINUTA { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal ID { get; set; }

        [StringLength(2)]
        public string ESTADO { get; set; }

        public DateTime? FEC_REG { get; set; }

        [StringLength(20)]
        public string USBD { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GRUPO { get; set; }

        [StringLength(20)]
        public string USAP { get; set; }

        public byte[] MINUTABASE { get; set; }

        [StringLength(1)]
        public string EDITABLE { get; set; }

        public byte[] MINUTAPDF { get; set; }
    }
}
