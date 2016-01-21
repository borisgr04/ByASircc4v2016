namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.DT_PARAMETROS")]
    public partial class DT_PARAMETROS
    {
        public decimal ID { get; set; }

        [StringLength(100)]
        public string NOMBRE { get; set; }

        [StringLength(100)]
        public string VALOR { get; set; }

        [StringLength(200)]
        public string DESCRIPCION { get; set; }
    }
}
