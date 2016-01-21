namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.TIPPLANTILLAS")]
    public partial class TIPPLANTILLAS
    {
        [Key]
        [StringLength(2)]
        public string ID_TIPPLA { get; set; }

        [StringLength(200)]
        public string NOM_TIPPLA { get; set; }
    }
}
