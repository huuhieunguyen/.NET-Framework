using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V_Cau1
{
  class KH_SanXuat : KhachHang
  {
    private int _loaiDien;
    public int LoaiDien
    {
      get { return _loaiDien; }
      set { _loaiDien = value; }
    }

    public KH_SanXuat() { }

    public KH_SanXuat(string maKH, string tenKH, Date ngayHD,
    double soDien, double donGia, int loaiDien) : base(maKH, tenKH, ngayHD, soDien, donGia)
    {
      this._loaiDien = loaiDien;
    }
    public override double TinhThanhTien()
    {
      double money = 0;
      if (_loaiDien == 2)
      {
        if (SoDien > 200)
        {
          money = (SoDien * DonGia) - ((SoDien - 200) * DonGia * 0.02);
        }
        else
        {
          money = SoDien * DonGia;

        }
      }
      if (_loaiDien == 3)
      {
        if (SoDien > 150)
        {
          money = (SoDien * DonGia) - ((SoDien - 200) * DonGia * 0.03);
        }
        else
        {
          money = SoDien * DonGia;
        }
      }
      return money;
    }
  }
}

