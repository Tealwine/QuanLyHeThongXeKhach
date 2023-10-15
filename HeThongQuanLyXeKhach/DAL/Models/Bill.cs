namespace DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Bill")]
    public partial class Bill
    {
        public int BillId { get; set; }

        public DateTime InvoiceDate { get; set; }

        public int? Total { get; set; }

        [Required]
        [StringLength(10)]
        public string Seat { get; set; }

        public int CustomerPhone { get; set; }

        [Required]
        [StringLength(30)]
        public string CustomerName { get; set; }

        [Required]
        [StringLength(10)]
        public string TripID { get; set; }

        public int TypeId { get; set; }

        public virtual TripInf TripInf { get; set; }
    }
}
