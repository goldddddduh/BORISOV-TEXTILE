//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace БОРИСОВ_ТЕКСТИЛЬ.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Страна_Производитель
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Страна_Производитель()
        {
            this.Товар = new HashSet<Товар>();
        }
    
        public int Код_Страны_Производителя { get; set; }
        public string Наименование { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Товар> Товар { get; set; }
    }
}
