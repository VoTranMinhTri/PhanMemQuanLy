//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace demo140421.ER
{
    using System;
    using System.Collections.Generic;
    
    public partial class Mau
    {
        public Mau()
        {
            this.SanPhams = new HashSet<SanPham>();
        }
    
        public int MaMau { get; set; }
        public string TenMau { get; set; }
        public Nullable<int> TrangThai { get; set; }
    
        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}