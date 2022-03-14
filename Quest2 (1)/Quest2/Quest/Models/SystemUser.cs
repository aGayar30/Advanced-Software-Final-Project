//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Quest.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SystemUser
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SystemUser()
        {
            this.userCarReservations = new HashSet<userCarReservation>();
            this.userTourReservations = new HashSet<userTourReservation>();
        }
    
        public decimal UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Nullable<decimal> UserTypeID { get; set; }
        public string UserEmail { get; set; }
    
        public virtual UserType UserType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<userCarReservation> userCarReservations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<userTourReservation> userTourReservations { get; set; }
    }
}