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
    
    public partial class PROJECT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PROJECT()
        {
            this.PROJACTs = new HashSet<PROJACT>();
            this.PROJECT1 = new HashSet<PROJECT>();
        }
    
        public string PROJNO { get; set; }
        public string PROJNAME { get; set; }
        public string DEPTNO { get; set; }
        public string RESPEMP { get; set; }
        public Nullable<decimal> PRSTAFF { get; set; }
        public Nullable<System.DateTime> PRSTDATE { get; set; }
        public Nullable<System.DateTime> PRENDATE { get; set; }
        public string MAJPROJ { get; set; }
    
        public virtual DEPARTMENT DEPARTMENT { get; set; }
        public virtual EMPLOYEE EMPLOYEE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROJACT> PROJACTs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROJECT> PROJECT1 { get; set; }
        public virtual PROJECT PROJECT2 { get; set; }
    }
}