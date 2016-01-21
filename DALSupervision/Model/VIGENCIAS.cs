namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.VIGENCIAS")]
    public partial class VIGENCIAS
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short YEAR_VIG { get; set; }

        public DateTime FEC_INI_VIG { get; set; }

        public DateTime? FEC_FIN_VIG { get; set; }

        public byte POR_ADI_VIG { get; set; }

        [Required]
        [StringLength(7)]
        public string EST_VIG { get; set; }

        [Required]
        [StringLength(1)]
        public string RAD_AUT { get; set; }
    }
}
