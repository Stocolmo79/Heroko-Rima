//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MakeMake
{
    using System;
    using System.Collections.Generic;
    
    public partial class tArea
    {
        public tArea()
        {
            this.tStaffAreas = new HashSet<tStaffArea>();
        }
    
        public int AreaId { get; set; }
        public string AreaDescription { get; set; }
    
        public virtual ICollection<tStaffArea> tStaffAreas { get; set; }
    }
}
