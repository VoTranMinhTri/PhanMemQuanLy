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
    
    public partial class CuaHang
    {
        public CuaHang()
        {
            this.NhanViens = new HashSet<NhanVien>();
            this.SP_PhanBo = new HashSet<SP_PhanBo>();
        }
    
        public int MaCH { get; set; }
        public string TenCH { get; set; }
        public string DiaChi { get; set; }
        public string HinhAnh { get; set; }
        public Nullable<int> TrangThai { get; set; }
    
        public virtual ICollection<NhanVien> NhanViens { get; set; }
        public virtual ICollection<SP_PhanBo> SP_PhanBo { get; set; }
    }
}
