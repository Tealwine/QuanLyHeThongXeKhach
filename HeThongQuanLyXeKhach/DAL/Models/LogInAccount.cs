namespace DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LogInAccount")]
    public partial class LogInAccount
    {
        [Key]
        [StringLength(10)]
        public string UserId { get; set; }

        [Required]
        [StringLength(20)]
        public string Pass { get; set; }
    }
}
