namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.AUDITORIA")]
    public partial class AUDITORIA
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_AUD { get; set; }

        [Required]
        [StringLength(30)]
        public string OBJ_AUD { get; set; }

        [Required]
        [StringLength(100)]
        public string ACC_AUD { get; set; }

        public DateTime FEC_AUD { get; set; }

        [Required]
        [StringLength(15)]
        public string USU_AUD { get; set; }

        public virtual USUARIOS USUARIOS { get; set; }
    }
}
