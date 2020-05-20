namespace RestZeaRide.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Bruger")]
    public partial class Bruger
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int brugerID { get; set; }

        [Required]
        [StringLength(30)]
        public string navn { get; set; }

        [Required]
        [StringLength(50)]
        public string efternavn { get; set; }

        public int? FK_bilID { get; set; }

        public int FK_postnummer { get; set; }

        [Required]
        [StringLength(100)]
        public string FK_email { get; set; }
    }
}
