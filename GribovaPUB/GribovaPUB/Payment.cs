//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GribovaPUB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Payment
    {
        public System.DateTime PaymentDate { get; set; }
        public string PaymentType_Name { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }
        public double UserId { get; set; }
        public bool IsPayed { get; set; }
        public int Id { get; set; }
    
        public virtual PaymentType PaymentType { get; set; }
        public virtual User User { get; set; }
    }
}
