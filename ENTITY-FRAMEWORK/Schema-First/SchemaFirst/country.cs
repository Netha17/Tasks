//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchemaFirst
{
    using System;
    using System.Collections.Generic;
    
    public partial class country
    {
        public country()
        {
            this.states = new HashSet<state>();
        }
    
        public int cid { get; set; }
        public string cname { get; set; }
    
        public virtual ICollection<state> states { get; set; }
    }
}
