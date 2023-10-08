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
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BillId { get; set; }

        [Required]
        [StringLength(10)]
        public string EmployeeId { get; set; }

        public DateTime? InvoiceDate { get; set; }

        public int? Number { get; set; }

        public int? Total { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual TicketInf TicketInf { get; set; }
    }
}
