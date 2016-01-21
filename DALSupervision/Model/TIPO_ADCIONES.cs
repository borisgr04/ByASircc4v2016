namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.TIPO_ADCIONES")]
    public partial class TIPO_ADCIONES
    {
        [Key]
        [StringLength(2)]
        public string COD_TIP { get; set; }

        [Required]
        [StringLength(30)]
        public string NOM_TIP { get; set; }
    }
}
