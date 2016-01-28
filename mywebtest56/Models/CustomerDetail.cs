namespace mywebtest56.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CustomerDetail
    {
        [Key]
        [StringLength(50)]
        public string CustID { get; set; }

        [Required]
        [StringLength(50)]
        public string CustName { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(50)]
        public string City { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }
    }
}
