using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore
{
  class SachTrinhTham : Sach
  {
    public bool thue
    {
      get { return thue; }
      set { thue = value; }
    }

    public SachTrinhTham() { }
    public SachTrinhTham(long ma, string ten, double dG, int sL, string nxb, float th)
    {
      this.thue = th;
    }

    public override string ToString()
    {
      Console.OutputEncoding = Encoding.UTF8;

      return "============THÔNG TIN SÁCH TRINH THÁM============" +
      "===========================================\n" +
      $"Mã sách: " + this.maSach +
      $"\nTên sách: " + this.tenSach +
      $"\nĐơn giá sách: " + this.donGia +
      $"\nSố lượng sách: " + this.soLuong +
      $"\nNhà xuất bản sách: " + this.NXB +
      $"\nThuế sách: " + this.thue +
      "\n===========================================";
    }

    public override double thanhTien()
    {
      return this.soLuong * this.donGia + this.thue;
    }
  }
}
