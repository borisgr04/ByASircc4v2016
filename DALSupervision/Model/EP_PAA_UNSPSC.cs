namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.EP_PAA_UNSPSC")]
    public partial class EP_PAA_UNSPSC
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int? ID_EP_PAA { get; set; }

        [StringLength(8)]
        public string UNSPSC { get; set; }

        public virtual EP_CODIGOSUNSPSC EP_CODIGOSUNSPSC { get; set; }

        public virtual EP_PAA EP_PAA { get; set; }
    }
}
