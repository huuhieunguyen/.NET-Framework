using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V_Cau2
{
  public class HangHoa
  {
    private string _maHang;
    private string _tenHang;
    private double _soTon;
    private double _donGia;

    public double MaHang
    {
      get { return _maHang; }
      set { _maHang = value; }
    }
    public double TenHang
    {
      get { return _tenHang; }
      set { _tenHang = value; }
    }
    public double SoLuongTon
    {
      get { return _soTon; }
      set { _soTon = value; }
    }
    public double DonGia
    {
      get { return _donGia; }
      set { _donGia = value; }
    }

    public HangHoa()
    {
      this._maHang = "";
      this._tenHang = "";
      this._soTon = 0;
      this._donGia = 0;
    }

    public HangHoa(string maHang, string tenHang, double soLuongTon, double donGia)
    {
      this._maHang = maHang;
      this._tenHang = tenHang;
      this._soTon = soLuongTon;
      this._donGia = donGia;
    }


  }
}