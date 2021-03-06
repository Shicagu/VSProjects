//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HousingCooperative
{
    using System;
    using System.Collections.Generic;
    
    public partial class Houses
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Houses()
        {
            this.Counters = new HashSet<Counters>();
            this.OwnersOfHouses = new HashSet<OwnersOfHouses>();
            this.Receipts = new HashSet<Receipts>();
        }
    
        public int IdHouse { get; set; }
        public int NumberHouse { get; set; }
        public int Section { get; set; }
        public int Floor { get; set; }
        public int NumberRooms { get; set; }
        public decimal Area { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Counters> Counters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OwnersOfHouses> OwnersOfHouses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Receipts> Receipts { get; set; }
    }
}
