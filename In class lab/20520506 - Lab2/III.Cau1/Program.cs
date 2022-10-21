using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaiKhoan
{
  class TaiKhoan
  {
    public long soTK
    {
      get { return soTK; }
      set { soTK = value; }
    }
    public string tenTK
    {
      get { return tenTK; }
      set { tenTK = value; }
    }
    public double soTien
    {
      get { return soTien; }
      set { soTien = value; }
    }

    public TaiKhoan()
    {
      this.soTien = 10;
    }
    public TaiKhoan(long soTK, string tenTK, double soTien)
    {
      this.soTK = soTK;
      this.tenTK = tenTK;
      this.soTien = 10;
    }

    public override string ToString()
    {
      Console.OutputEncoding = Encoding.UTF8;

      return "============THÔNG TIN TÀI KHOẢN============" +
      "===========================================\n" +
      $"Số tài khoản " + this.soTK +
      $"\nTên tài khoản " + this.tenTK +
      $"\nSố tiền trong tài khoản " + this.soTien +
      "\n===========================================";
    }

    public bool napTien(double soTien)
    {
      if (soTien > 0)
      {
        this.soTien = this.soTien + soTien;
        return true;
      }
      return false;
    }

    public bool rutTien(double tienRut)
    {
      if (tienRut > 0 && tienRut < this.soTien)
      {
        this.soTien = this.soTien - tienRut;
        return true;
      }
      return false;
    }
  }

  class Program
  {
    public static void Main()
    {
      TaiKhoan tk = new TaiKhoan();
      tk.ToString();
    }
  }
}
