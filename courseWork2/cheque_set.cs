//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace courseWork2
{
    using System;
    using System.Collections.Generic;
    
    public partial class cheque_set
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cheque_set()
        {
            this.status_of_cheque = new HashSet<status_of_cheque>();
        }
    
        public int cheque_prod_id { get; set; }
        public int cheque_id { get; set; }
        public int product_address_id { get; set; }
        public Nullable<int> cheque_product_amount { get; set; }
    
        public virtual cheque cheque { get; set; }
        public virtual product_address product_address { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<status_of_cheque> status_of_cheque { get; set; }
    }
}
