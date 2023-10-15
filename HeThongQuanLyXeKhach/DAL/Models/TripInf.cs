namespace DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TripInf")]
    public partial class TripInf
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TypeId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string TripID { get; set; }

        public int Price { get; set; }

        public virtual CoachType CoachType { get; set; }

        public virtual Trip Trip { get; set; }
    }
}
