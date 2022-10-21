using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V_Cau1
{
  class KH_KinhDoanh : KhachHang
  {
    public KH_KinhDoanh() { }

    public KH_KinhDoanh(string maKH, string tenKH, Date ngayHD,
    double soDien, double donGia) : base(maKH, tenKH, ngayHD, soDien, donGia) { }
    public override double TinhThanhTien()
    {
      if (SoDien <= 400)
      {
        return SoDien * DonGia;
      }
      else
      {
        return SoDien * DonGia + (SoDien * DonGia * 0.05);
      }
    }
  }
}

