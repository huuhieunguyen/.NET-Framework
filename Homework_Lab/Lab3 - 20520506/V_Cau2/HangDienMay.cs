using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V_Cau2
{
  public class HangDienMay : HangHoa
  {
    private string _thuongHieu;
    private string _loaiMay;
    private int _thoiGianBH;

    public string ThuongHieu
    {
      get { return _thuongHieu; }
      set { _thuongHieu = value; }
    }

    public HangDienMay() : base()
    {
      _thuongHieu = "";
      _thoiGianBH = 0;
      _loaiMay = "";
    }

    public HangDienMay(string maHang, string tenHang, double soLuongTon, double donGia, string thuongHieu, string loaiMay, int tgBH) :
    base(maHang, tenHang, soLuongTon, donGia)
    {
      _thuongHieu = thuongHieu;
      _loaiMay = loaiMay;
      _thoiGianBH = tgBH;
    }
  }
}