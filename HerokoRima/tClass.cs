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
    
    public partial class tClass
    {
        public tClass()
        {
            this.tStaffClasses = new HashSet<tStaffClass>();
        }
    
        public long ClassId { get; set; }
        public Nullable<int> TypeId { get; set; }
        public System.DateTime ClassDate { get; set; }
        public Nullable<int> MaxAttendance { get; set; }
        public Nullable<int> Attendance { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
    
        public virtual ICollection<tStaffClass> tStaffClasses { get; set; }
    }
}