//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HerokoRima
{
    using System;
    using System.Collections.Generic;
    
    public partial class tStaffClass
    {
        public int ID { get; set; }
        public long StaffId { get; set; }
        public long ClassId { get; set; }
    
        public virtual tStaff tStaff { get; set; }
        public virtual tClass tClass { get; set; }
    }
}