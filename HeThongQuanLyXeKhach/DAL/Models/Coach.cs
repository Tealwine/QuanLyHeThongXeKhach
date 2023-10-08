namespace DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Coach")]
    public partial class Coach
    {
        [StringLength(10)]
        public string CoachId { get; set; }

        [StringLength(12)]
        public string CoachPlate { get; set; }

        [StringLength(30)]
        public string CoachBrand { get; set; }

        public int? SeatNumber { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Warranty { get; set; }

        public int TypeId { get; set; }

        public virtual CoachType CoachType { get; set; }
    }
}
