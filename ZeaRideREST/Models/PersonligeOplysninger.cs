namespace ZeaRideREST.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PersonligeOplysninger")]
    public partial class PersonligeOplysninger
    {
        [Key]
        [StringLength(100)]
        public string email { get; set; }

        [Required]
        [StringLength(100)]
        public string kodeord { get; set; }
    }
}
