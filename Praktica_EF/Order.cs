//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Praktica_EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int ID_Order { get; set; }
        public Nullable<int> ID_Client { get; set; }
        public Nullable<int> ID_Product { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<decimal> TotalPrice { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Product Product { get; set; }
    }
}
