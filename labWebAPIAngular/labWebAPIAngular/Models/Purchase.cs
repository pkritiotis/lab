//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace labWebAPIAngular.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Purchase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Purchase()
        {
            this.Purchase_Buy_Product = new HashSet<Purchase_Buy_Product>();
        }
    
        public int id { get; set; }
        public int supplier_id { get; set; }
        public System.DateTime added_on_date { get; set; }
        public Nullable<System.DateTime> modified_on_date { get; set; }
        public Nullable<double> total_price { get; set; }
        public Nullable<System.DateTime> completed_on_date { get; set; }
        public Nullable<System.DateTime> paid_on_date { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Purchase_Buy_Product> Purchase_Buy_Product { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
