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
    
    public partial class HoaDonNhap
    {
        public HoaDonNhap()
        {
            this.CT_HoaDonNhap = new HashSet<CT_HoaDonNhap>();
        }
    
        public int MaHD { get; set; }
        public Nullable<System.DateTime> NgayLap { get; set; }
        public Nullable<int> MaNCC { get; set; }
        public Nullable<int> TrangThai { get; set; }
    
        public virtual ICollection<CT_HoaDonNhap> CT_HoaDonNhap { get; set; }
        public virtual NhaCungCap NhaCungCap { get; set; }
    }
}
