using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V_Cau2
{
  public class HangGiaDung : HangHoa
  {
    private DateTime _ngayNhap;
    private string _nhaSX;

    private string _loaiGD;
    public DateTime NgayNhap
    {
      get { return _ngayNhap; }
      set { _ngayNhap = value; }
    }
    public string NhaSX
    {
      get { return _nhaSX; }
      set { _nhaSX = value; }
    }
    public string LoaiGD
    {
      get { return _loaiGD; }
      set { _loaiGD = value; }
    }
    public HangGiaDung() : base() { }

    public HangGiaDung(string maHang, string tenHang, double soLuongTon, double donGia, string nhaSX, DateTime ngayNhap, string loaiGD) :
    base(maHang, tenHang, soLuongTon, donGia)
    {
      _ngayNhap = ngayNhap;
      _nhaSX = nhaSX;
      _loaiGD = loaiGD;
    }
  }
}