//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WPF_3._0
{
    using System;
    using System.Collections.Generic;
    
    public partial class Volunteer
    {
        public int VolunteerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CountryCode { get; set; }
        public string Gender { get; set; }
    
        public virtual Country Country { get; set; }
        public virtual Gender Gender1 { get; set; }
    }
}
