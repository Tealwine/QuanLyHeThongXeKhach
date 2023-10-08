namespace DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TicketInf")]
    public partial class TicketInf
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BillId { get; set; }

        [Required]
        [StringLength(10)]
        public string TripID { get; set; }

        public int CustomerId { get; set; }

        [StringLength(10)]
        public string Seat { get; set; }

        public virtual Bill Bill { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Trip Trip { get; set; }
    }
}
