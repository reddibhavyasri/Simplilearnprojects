//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ECommerceWebsite.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ordertable
    {
        public int Orderid { get; set; }
        public Nullable<int> OrderFkProduct { get; set; }
        public Nullable<int> OrderFkuser { get; set; }
        public Nullable<int> OrderFkinvoice { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public Nullable<int> Orderquantity { get; set; }
        public Nullable<double> Orderbill { get; set; }
        public Nullable<int> Orderunitprice { get; set; }
    
        public virtual Invoicetable Invoicetable { get; set; }
        public virtual ProductTable ProductTable { get; set; }
        public virtual Usertable Usertable { get; set; }
    }
}
