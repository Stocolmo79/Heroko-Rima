//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Classes
{
    using System;
    using System.Collections.Generic;
    
    public partial class tOrder
    {
        public tOrder()
        {
            this.tOrderItems = new HashSet<tOrderItem>();
        }
    
        public int OrderId { get; set; }
        public Nullable<long> MemberId { get; set; }
        public Nullable<long> TotalAmount { get; set; }
    
        public virtual ICollection<tOrderItem> tOrderItems { get; set; }
    }
}
