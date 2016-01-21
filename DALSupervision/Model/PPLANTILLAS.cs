namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.PPLANTILLAS")]
    public partial class PPLANTILLAS
    {
        public PPLANTILLAS()
        {
            PPLANTILLAS_FORMATO_TABLAS = new HashSet<PPLANTILLAS_FORMATO_TABLAS>();
        }

        [Key]
        public decimal IDE_PLA { get; set; }

        [StringLength(20)]
        public string TIP_PLA { get; set; }

        [StringLength(20)]
        public string NOM_PLA { get; set; }

        public byte[] PLANTILLA { get; set; }

        [StringLength(10)]
        public string EXT { get; set; }

        [StringLength(2)]
        public string EST_PLA { get; set; }

        [StringLength(5)]
        public string COD_STIP { get; set; }

        [StringLength(20)]
        public string USAP { get; set; }

        [StringLength(20)]
        public string USBD { get; set; }

        public DateTime? FEC_REG { get; set; }

        [StringLength(20)]
        public string USBD_MOD { get; set; }

        [StringLength(20)]
        public string USAP_MOD { get; set; }

        public DateTime? FEC_MOD { get; set; }

        [StringLength(20)]
        public string CLAVE { get; set; }

        [StringLength(1)]
        public string EDITABLE { get; set; }

        public virtual INT_PPLANTILLAS_URL INT_PPLANTILLAS_URL { get; set; }

        public virtual ICollection<PPLANTILLAS_FORMATO_TABLAS> PPLANTILLAS_FORMATO_TABLAS { get; set; }
    }
}
