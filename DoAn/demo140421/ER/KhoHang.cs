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
    
    public partial class KhoHang
    {
        public int MaSP { get; set; }
        public int MaMau { get; set; }
        public int MaSize { get; set; }
        public Nullable<int> SoLuong { get; set; }
    
        public virtual SanPham SanPham { get; set; }
    }
}