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
    
    public partial class Abonents
    {
        public int IdAbonent { get; set; }
        public string LFM { get; set; }
        public int IdMF { get; set; }
        public System.DateTime Birthday { get; set; }
        public string NumberPhone { get; set; }
        public string Email { get; set; }
        public string AdressPasport { get; set; }
        public string AdressReal { get; set; }
        public string SerAndNumPasport { get; set; }
        public string CodePPasport { get; set; }
        public string WhoDropPasport { get; set; }
        public System.DateTime DateDropPasport { get; set; }
        public string NumberDoc { get; set; }
        public System.DateTime DateCreateDoc { get; set; }
        public int IdTypeDoc { get; set; }
        public string CommentDestroyDoc { get; set; }
        public string LS { get; set; }
        public int IdServices { get; set; }
        public Nullable<System.DateTime> DateDestroyDoc { get; set; }
        public string DocArend { get; set; }
        public string SerNumDevice { get; set; }
        public string NumberAbonent { get; set; }
    
        public virtual MF MF { get; set; }
        public virtual Services Services { get; set; }
        public virtual TypesDoc TypesDoc { get; set; }
    }
}
