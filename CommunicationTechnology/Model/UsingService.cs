//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CommunicationTechnology.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class UsingService
    {
        public int Id { get; set; }
        public string CodeService { get; set; }
        public Nullable<System.DateTime> DateConnection { get; set; }
        public string NumberPhone { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Services Services { get; set; }
    }
}