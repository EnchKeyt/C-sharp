//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TNSDesktop
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tarifs
    {
        public int Id { get; set; }
        public int IdService { get; set; }
        public string NameTarif { get; set; }
        public string Yslov { get; set; }
        public string Price { get; set; }
    
        public virtual Services Services { get; set; }
    }
}
