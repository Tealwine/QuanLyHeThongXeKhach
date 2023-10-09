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

        [Required]
        [StringLength(12)]
        public string CoachPlate { get; set; }

        [StringLength(30)]
        public string CoachBrand { get; set; }

        public int SeatNumber { get; set; }

        public int Warranty { get; set; }

        public int TypeId { get; set; }

        [StringLength(255)]
        public string CoachImg { get; set; }

        public virtual CoachType CoachType { get; set; }
    }
}
