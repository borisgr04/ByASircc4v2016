namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.HDEP_ABOGADOS")]
    public partial class HDEP_ABOGADOS
    {
        [StringLength(2)]
        public string COD_DEP { get; set; }

        [StringLength(15)]
        public string IDE_TER { get; set; }

        public DateTime? FEC_ASIGNACION { get; set; }

        public DateTime? FEC_RETIRO { get; set; }

        [StringLength(15)]
        public string USAP { get; set; }

        [StringLength(15)]
        public string USBD { get; set; }

        [StringLength(15)]
        public string USAP_RETIRO { get; set; }

        [StringLength(2)]
        public string ESTADO { get; set; }

        [Key]
        public decimal ID_HDEP { get; set; }

        [StringLength(2)]
        public string ASIG_PROC { get; set; }

        [StringLength(2)]
        public string COORDINADOR { get; set; }

        public virtual DEPENDENCIA DEPENDENCIA { get; set; }

        public virtual TERCEROS TERCEROS { get; set; }
    }
}
