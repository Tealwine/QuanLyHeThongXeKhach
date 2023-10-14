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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bill()
        {
            TicketInfs = new HashSet<TicketInf>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BillId { get; set; }

        [Required]
        [StringLength(10)]
        public string EmployeeId { get; set; }

        public DateTime InvoiceDate { get; set; }

        public int Number { get; set; }

        public int? Total { get; set; }

        public virtual Employee Employee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TicketInf> TicketInfs { get; set; }
    }
}
