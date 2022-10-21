using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore
{
  class SachTieuThuyet : Sach
  {
    public bool tinhTrang
    {
      get { return tinhTrang; }
      set { tinhTrang = value; }
    }

    public SachTieuThuyet() { }
    public SachTieuThuyet(long ma, string ten, double dG, int sL, string nxb, bool tTrang)
    {
      this.tinhTrang = tTrang;
    }

    public override string ToString()
    {
      Console.OutputEncoding = Encoding.UTF8;

      return "============THÔNG TIN SÁCH TIỂU THUYẾT============" +
      "===========================================\n" +
      $"Mã sách: " + this.maSach +
      $"\nTên sách: " + this.tenSach +
      $"\nĐơn giá sách: " + this.donGia +
      $"\nSố lượng sách: " + this.soLuong +
      $"\nNhà xuất bản sách: " + this.NXB +
      $"\nTình trạng sách: " + this.tinhTrang +
      "\n===========================================";
    }

    public override double thanhTien()
    {
      if (this.tinhTrang)
      {
        return this.soLuong * this.donGia;
      }
      else
      {
        return this.soLuong * this.donGia * 0.8;
      }
    }
  }
}
