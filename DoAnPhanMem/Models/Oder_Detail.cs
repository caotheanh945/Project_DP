//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAnPhanMem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Oder_Detail
    {
        public int pro_id { get; set; }
        public int cate_id { get; set; }
        public int discount_id { get; set; }
        public int oder_id { get; set; }
        public double price { get; set; }
        public string status { get; set; }
        public int quantity { get; set; }
    
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
