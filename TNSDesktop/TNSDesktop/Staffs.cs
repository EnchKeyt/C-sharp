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
    
    public partial class Staffs
    {
        public int IdStaff { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public int IdRole { get; set; }
        public string PhotoPatch { get; set; }
    
        public virtual Roles Roles { get; set; }
    }
}