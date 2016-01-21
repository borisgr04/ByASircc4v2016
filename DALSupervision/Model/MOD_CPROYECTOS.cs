namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.MOD_CPROYECTOS")]
    public partial class MOD_CPROYECTOS
    {
        [Key]
        [StringLength(15)]
        public string NUM_SOL_ADI { get; set; }

        [StringLength(30)]
        public string PROYECTO { get; set; }

        [StringLength(15)]
        public string COD_CON { get; set; }

        public DateTime? FEC_REG { get; set; }

        [StringLength(20)]
        public string USBD { get; set; }

        [StringLength(20)]
        public string USAP { get; set; }

        public DateTime? FEC_MOD { get; set; }

        [StringLength(20)]
        public string USBD_MOD { get; set; }

        [StringLength(20)]
        public string USAP_MOD { get; set; }

        public virtual PROYECTOS PROYECTOS { get; set; }

        public virtual SOL_ADICIONES SOL_ADICIONES { get; set; }
    }
}
