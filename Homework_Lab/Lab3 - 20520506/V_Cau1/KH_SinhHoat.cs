using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V_Cau1
{
  class KH_SinhHoat : KhachHang
  {
    private double _dinhMuc;
    public double DinhMuc
    {
      get { return _dinhMuc; }
      set { _dinhMuc = value; }
    }

    public KH_SinhHoat() { }

    public KH_SinhHoat(string maKH, string tenKH, Date ngayHD,
    double soDien, double donGia, double dinhMuc) : base(maKH, tenKH, ngayHD, soDien, donGia)
    {
      this._dinhMuc = dinhMuc;
    }
    public override double TinhThanhTien()
    {
      if (SoDien <= _dinhMuc)
      {
        return SoDien * DonGia;
      }
      else
      {
        return (SoDien * DonGia + _dinhMuc) + DonGia * (SoDien - _dinhMuc) * 2;
      }
    }
  }
}

