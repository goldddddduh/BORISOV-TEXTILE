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
    
    public partial class Товар
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Товар()
        {
            this.Корзина = new HashSet<Корзина>();
            this.Склад = new HashSet<Склад>();
            this.Состав_Заказа = new HashSet<Состав_Заказа>();
        }
    
        public int Код_Товара { get; set; }
        public string Наименование { get; set; }
        public string Техническая_Характеристика { get; set; }
        public decimal Цена { get; set; }
        public int Код_Страны_Производителя { get; set; }
        public byte[] Фото { get; set; }
        public string Длина { get; set; }
        public string Описание { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Корзина> Корзина { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Склад> Склад { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Состав_Заказа> Состав_Заказа { get; set; }
        public virtual Страна_Производитель Страна_Производитель { get; set; }
    }
}
