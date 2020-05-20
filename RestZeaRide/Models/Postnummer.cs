namespace RestZeaRide.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Postnummer")]
    public partial class Postnummer
    {
        [Key]
        [Column("postnummer")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int postnummer1 { get; set; }

        [Required]
        [StringLength(50)]
        public string bynavn { get; set; }
    }
}
