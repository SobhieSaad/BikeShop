using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BikesShop.Models
{
    public class ProductCommentRate
    {
        public Product Product { get; set; }

        public CustomersComment CustomersComment { get; set; }

        public ProductRate ProductRate { get; set; }

        public List<CustomersComment> ListComments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomersComment> CustssComments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductRate> ProductRates { get; set; }
    }
}