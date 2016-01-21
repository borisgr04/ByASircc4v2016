namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.PLANTILLAPPAL")]
    public partial class PLANTILLAPPAL
    {
        [StringLength(100)]
        public string NOMBRE { get; set; }

        public byte[] PLANTILLA { get; set; }

        public decimal ID { get; set; }
    }
}
