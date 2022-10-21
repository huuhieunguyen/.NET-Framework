using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V_Cau1
{
  abstract class KhachHang
  {
    private string _maKH;
    private string _tenKH;
    private Date _ngayHD;
    private double _soDien;
    private double _donGia;

    public string MaKH
    {
      get { return _maKH; }
      set { _maKH = value; }
    }

    public string TenKH
    {
      get { return _tenKH; }
      set { _tenKH = value; }
    }

    public Date NgayHD
    {
      get { return _ngayHD; }
      set { _ngayHD = value; }
    }

    public double SoDien
    {
      get { return _soDien; }
      set { _soDien = value; }
    }

    public double DonGia
    {
      get { return _donGia; }
      set { _donGia = value; }
    }

    public KhachHang()
    {
      this._maKH = "";
      this._tenKH = "";
      this._ngayHD.nam = 1;
      this._ngayHD.thang = 1;
      this._soDien = 0;
      this._donGia = 0;
    }

    public KhachHang(string maKH, string tenKH, Date ngayHD, double soDien, double donGia)
    {
      this._maKH = maKH;
      this._tenKH = tenKH;
      this._ngayHD = ngayHD;
      this._soDien = soDien;
      this._donGia = donGia;
    }

    // Tính điểm trung bình
    public abstract double TinhThanhTien();

    public override string ToString()
    {
      return $"Mã: {_maKH}\t Tên: {_tenKH}\t Ngày HD: {_ngayHD}\t Số lượng điện: {_soDien}\t Đơn giá: {_donGia} \t Thành tiền: {TinhThanhTien()}s";
    }
  }
}