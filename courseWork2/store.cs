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
    
    public partial class store
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public store()
        {
            this.store_address = new HashSet<store_address>();
        }
    
        public int store_id { get; set; }
        public string store_name { get; set; }
        public string store_code { get; set; }
        public string store_info { get; set; }
        public string store_password { get; set; }
        public string store_role { get; set; }
        public byte[] store_logo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<store_address> store_address { get; set; }
    }
}
