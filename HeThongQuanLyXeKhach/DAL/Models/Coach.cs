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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Coach()
        {
            TripInfs = new HashSet<TripInf>();
        }

        [StringLength(10)]
        public string CoachId { get; set; }

        [Required]
        [StringLength(12)]
        public string CoachPlate { get; set; }

        [StringLength(30)]
        public string CoachBrand { get; set; }

        public int Warranty { get; set; }

        public int TypeId { get; set; }

        [StringLength(255)]
        public string CoachImg { get; set; }

        public virtual CoachType CoachType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TripInf> TripInfs { get; set; }
    }
}
