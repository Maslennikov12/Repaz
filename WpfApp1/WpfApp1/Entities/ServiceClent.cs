//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp1.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class ServiceClent
    {
        public int id { get; set; }
        public Nullable<int> idNameService { get; set; }
        public Nullable<System.DateTime> StartService { get; set; }
        public Nullable<int> idClient { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual NameService NameService { get; set; }
    }
}
