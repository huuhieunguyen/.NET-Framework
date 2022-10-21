using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V_Cau2
{
  public class HangThucPham : HangHoa
  {
    private DateTime _ngaySX;
    private DateTime _ngayHH;

    private string _nhaCungCap;
    public DateTime NgaySX
    {
      get { return _ngaySX; }
      set { _ngaySX = value; }
    }

    public DateTime NgayHH
    {
      get { return _ngayHH; }
      set { _ngayHH = value; }
    }

    public string NhaCungCap
    {
      get { return _nhaCungCap; }
      set { _nhaCungCap = value; }
    }
    public HangThucPham() : base() { }

    public HangThucPham(string maHang, string tenHang, double soLuongTon, double donGia, DateTime ngaySX, DateTime ngayHH, string nhaCC) :
    base(maHang, tenHang, soLuongTon, donGia)
    {
      _ngaySX = ngaySX;
      _ngayHH = ngayHH;
      _nhaCungCap = nhaCC;
    }
  }
}