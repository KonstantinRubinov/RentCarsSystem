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
    
    public partial class CAR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CAR()
        {
            this.CARFORRENTS = new HashSet<CARFORRENT>();
        }
    
        public double carKm { get; set; }
        public string carPicture { get; set; }
        public bool carInShape { get; set; }
        public bool carAvaliable { get; set; }
        public string carNumber { get; set; }
        public int carBranchID { get; set; }
        public int carTypeID { get; set; }
    
        public virtual ALLCARTYPE ALLCARTYPE { get; set; }
        public virtual BRANCH BRANCH { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CARFORRENT> CARFORRENTS { get; set; }
    }
}