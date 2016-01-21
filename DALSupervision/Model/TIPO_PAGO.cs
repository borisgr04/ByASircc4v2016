namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.TIPO_PAGO")]
    public partial class TIPO_PAGO
    {
        public TIPO_PAGO()
        {
            C_FORMA_PAGO = new HashSet<C_FORMA_PAGO>();
            CFORMA_PAGO = new HashSet<CFORMA_PAGO>();
            EP_FORMA_PAGO = new HashSet<EP_FORMA_PAGO>();
            MOD_CFORMA_PAGO = new HashSet<MOD_CFORMA_PAGO>();
            PAGOS_GPROCESOS = new HashSet<PAGOS_GPROCESOS>();
            PAGOS_PARCIALES = new HashSet<PAGOS_PARCIALES>();
        }

        [Key]
        [StringLength(2)]
        public string ID_PAGO { get; set; }

        [StringLength(100)]
        public string DES_PAGO { get; set; }

        [StringLength(15)]
        public string USUARIO { get; set; }

        public DateTime? FEC_REG { get; set; }

        [StringLength(15)]
        public string USBD { get; set; }

        public DateTime? FEC_MOD { get; set; }

        public virtual ICollection<C_FORMA_PAGO> C_FORMA_PAGO { get; set; }

        public virtual ICollection<CFORMA_PAGO> CFORMA_PAGO { get; set; }

        public virtual ICollection<EP_FORMA_PAGO> EP_FORMA_PAGO { get; set; }

        public virtual ICollection<MOD_CFORMA_PAGO> MOD_CFORMA_PAGO { get; set; }

        public virtual ICollection<PAGOS_GPROCESOS> PAGOS_GPROCESOS { get; set; }

        public virtual ICollection<PAGOS_PARCIALES> PAGOS_PARCIALES { get; set; }
    }
}
