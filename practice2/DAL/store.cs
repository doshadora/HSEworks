//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace practice2.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class store
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public store()
        {
            this.product = new HashSet<product>();
        }
    
        public int store_id { get; set; }
        public string store_name { get; set; }
        public string store_code { get; set; }
        public string store_info { get; set; }
        public string store_password { get; set; }
        public string store_role { get; set; }
        public byte[] store_logo { get; set; }
        public string store_address { get; set; }
        public int city_id { get; set; }
    
        public virtual dict_city dict_city { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<product> product { get; set; }
    }
}
