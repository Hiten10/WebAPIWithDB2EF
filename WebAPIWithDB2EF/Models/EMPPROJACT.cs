//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAPIWithDB2EF.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class EMPPROJACT
    {
        public string EMPNO { get; set; }
        public string PROJNO { get; set; }
        public short ACTNO { get; set; }
        public Nullable<decimal> EMPTIME { get; set; }
        public Nullable<System.DateTime> EMSTDATE { get; set; }
        public Nullable<System.DateTime> EMENDATE { get; set; }
    
        public virtual PROJACT PROJACT { get; set; }
    }
}
