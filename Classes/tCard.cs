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
    
    public partial class tCard
    {
        public tCard()
        {
            this.tCardUsages = new HashSet<tCardUsage>();
            this.tMembers = new HashSet<tMember>();
        }
    
        public long CardId { get; set; }
        public int TypeId { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<int> Tickets { get; set; }
        public System.DateTime Changed { get; set; }
        public Nullable<bool> Enabled { get; set; }
    
        public virtual ICollection<tCardUsage> tCardUsages { get; set; }
        public virtual tPrice tPrice { get; set; }
        public virtual ICollection<tMember> tMembers { get; set; }
    }
}
