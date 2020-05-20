namespace RestZeaRide.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Samkorsel")]
    public partial class Samkorsel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int samkorselID { get; set; }

        [Required]
        [StringLength(255)]
        public string fraDestination { get; set; }

        [Required]
        [StringLength(255)]
        public string tilDestination { get; set; }

        [StringLength(255)]
        public string bemaerkninger { get; set; }

        [Column(TypeName = "date")]
        public DateTime dato { get; set; }

        public TimeSpan tid { get; set; }

        public int? deltagerID { get; set; }
    }
}
