namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.GPPROYECTOS")]
    public partial class GPPROYECTOS
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(30)]
        public string PROYECTO { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string NUM_PROC { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GRUPO { get; set; }

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

        public virtual GPROCESOS GPROCESOS { get; set; }
    }
}
