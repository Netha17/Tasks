//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Schema_First
{
    using System;
    using System.Collections.Generic;
    
    public partial class state
    {
        public int sid { get; set; }
        public string sname { get; set; }
        public Nullable<int> cid { get; set; }
    
        public virtual country country { get; set; }
    }
}