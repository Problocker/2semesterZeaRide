namespace ZeaRideREST.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Bil")]
    public partial class Bil
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int bilID { get; set; }

        [StringLength(100)]
        public string bilmodel { get; set; }

        [StringLength(100)]
        public string bilfarve { get; set; }
    }
}
