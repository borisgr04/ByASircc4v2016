namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.USUARIOS")]
    public partial class USUARIOS
    {
        public USUARIOS()
        {
            ANX_CONTRATOS = new HashSet<ANX_CONTRATOS>();
            AUDITORIA = new HashSet<AUDITORIA>();
        }

        [Key]
        [StringLength(10)]
        public string USERNAME { get; set; }

        [Required]
        [StringLength(50)]
        public string PASSWORD { get; set; }

        [Required]
        [StringLength(25)]
        public string CED_USU { get; set; }

        [Required]
        [StringLength(25)]
        public string APE_USU { get; set; }

        [Required]
        [StringLength(25)]
        public string NOM_USU { get; set; }

        [Required]
        [StringLength(20)]
        public string PER_USU { get; set; }

        [Required]
        [StringLength(2)]
        public string ESTADO { get; set; }

        public virtual ICollection<ANX_CONTRATOS> ANX_CONTRATOS { get; set; }

        public virtual ICollection<AUDITORIA> AUDITORIA { get; set; }
    }
}
