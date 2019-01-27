//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BikesShop.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            this.Orders = new HashSet<Order>();
            this.CustomersComments = new HashSet<CustomersComment>();
            this.ProductRates = new HashSet<ProductRate>();
        }
    
        public int ID { get; set; }
        public string Marital_Status { get; set; }
        public string Gender { get; set; }
        public Nullable<double> Income { get; set; }
        public Nullable<double> Children { get; set; }
        public string Education { get; set; }
        public string Occupation { get; set; }
        public string Home_Owner { get; set; }
        public Nullable<double> Cars { get; set; }
        public string Commute_Distance { get; set; }
        public string Region { get; set; }
        public Nullable<double> Age { get; set; }
        public string Buy { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomersComment> CustomersComments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductRate> ProductRates { get; set; }
    }
}