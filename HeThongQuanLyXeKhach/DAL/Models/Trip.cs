namespace DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Trip")]
    public partial class Trip
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Trip()
        {
            TicketInfs = new HashSet<TicketInf>();
            TripInfs = new HashSet<TripInf>();
        }

        [StringLength(10)]
        public string TripID { get; set; }

        public DateTime? StartTime { get; set; }

        public DateTime? ArriveTime { get; set; }

        [StringLength(30)]
        public string StartPlace { get; set; }

        [StringLength(30)]
        public string ArrivePlace { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TicketInf> TicketInfs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TripInf> TripInfs { get; set; }
    }
}
