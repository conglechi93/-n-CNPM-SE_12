//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CNPM_SE_12.DTO
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.Accounts = new HashSet<Account>();
        }
    
        public string ID_Account { get; set; }
        public string User_Name { get; set; }
        public bool Gender { get; set; }
        public System.DateTime Birthday { get; set; }
        public string NumberPhone { get; set; }
        public string Pasport { get; set; }
        public string Address { get; set; }
        public string Shift_Time { get; set; }
        public Nullable<int> Salary { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Account> Accounts { get; set; }
    }
}
