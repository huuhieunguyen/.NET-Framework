using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore
{
  class Sach
  {
    public long maSach
    {
      get { return maSach; }
      set { maSach = value; }
    }
    public string tenSach
    {
      get { return tenSach; }
      set { tenSach = value; }
    }
    public double donGia
    {
      get { return donGia; }
      set { donGia = value; }
    }

    public int soLuong
    {
      get { return soLuong; }
      set { soLuong = value; }
    }
    public string NXB
    {
      get { return NXB; }
      set { NXB = value; }
    }

    public Sach() { }
    public Sach(long maSach, string tenSach, double donGia, int soLuong, string nxb)
    {
      this.maSach = maSach;
      this.tenSach = tenSach;
      this.donGia = donGia;
      this.soLuong = soLuong;
      this.NXB = nxb;
    }

    public virtual string ToString()
    {
      // Console.OutputEncoding = Encoding.UTF8;

      // return "============THÔNG TIN SÁCH============" +
      // "===========================================\n" +
      // $"Mã sách: " + this.maSach +
      // $"\nTên sách: " + this.tenSach +
      // $"\nĐơn giá sách: " + this.donGia +
      // $"\nSố lượng sách: " + this.soLuong +
      // $"\nNhà xuất bản sách: " + this.NXB +
      // "\n===========================================";
    }

    public virtual double thanhTien()
    {
      // return this.soLuong * this.donGia;
    }
  }

  class Program
  {
    public static void Main()
    {
      Sach book = new Sach();
      book.ToString();
    }
  }
}
