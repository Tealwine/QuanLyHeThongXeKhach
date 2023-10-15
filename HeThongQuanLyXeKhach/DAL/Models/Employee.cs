namespace DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            LogInAccounts = new HashSet<LogInAccount>();
        }

        [StringLength(10)]
        public string EmployeeId { get; set; }

        [Required]
        [StringLength(30)]
        public string EmployeeName { get; set; }

        [Required]
        [StringLength(10)]
        public string Gender { get; set; }

        [Column(TypeName = "date")]
        public DateTime Birth { get; set; }

        [Required]
        [StringLength(11)]
        public string Phone { get; set; }

        [Required]
        [StringLength(50)]
        public string EmpAddress { get; set; }

        [StringLength(255)]
        public string Avatar { get; set; }

        public int PositionId { get; set; }

        public virtual Position Position { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LogInAccount> LogInAccounts { get; set; }
    }
}
