namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.GD_DDOCUMENTOS")]
    public partial class GD_DDOCUMENTOS
    {
        public decimal ID { get; set; }

        public byte[] DOCUMENTO { get; set; }

        public virtual GD_DOCUMENTOS GD_DOCUMENTOS { get; set; }
    }
}
