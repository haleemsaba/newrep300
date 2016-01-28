namespace mywebtest56.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Customer : DbContext
    {
        public Customer()
            : base("name=Customer")
        {
        }

        public virtual DbSet<CustomerDetail> CustomerDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
