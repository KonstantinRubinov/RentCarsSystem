//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RentCars.EntityDataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class BRANCH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BRANCH()
        {
            this.CARS = new HashSet<CAR>();
        }
    
        public string branchAddress { get; set; }
        public double branchLat { get; set; }
        public double branchLng { get; set; }
        public string branchName { get; set; }
        public int branchID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CAR> CARS { get; set; }
    }
}