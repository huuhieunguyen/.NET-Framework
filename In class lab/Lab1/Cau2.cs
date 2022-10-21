using System;

namespace Lab1
{
  class PhanSo
  {
    private int Tu, Mau;

    // Ham nhap phan so
    public void nhap()
    {
      // Nhap tu so
      while (true)
      {
        try
        {
          Console.Write("\nNhap vao tu so: ");
          Tu = int.Parse(Console.ReadLine());
          break;
        }
        catch
        {
          Console.Write("\nNhap sai kieu du lieu. Vui long nhap lai!");
        }
      }

      // Nhap mau so
      while (true)
      {
        try
        {
          Console.Write("\nNhap vao mau so: ");
          Mau = int.Parse(Console.ReadLine());

          if (Mau == 0)
            Console.Write("\nMau khac 0. Vui long nhap lai!");
          else
            break;
        }
        catch
        {
          Console.Write("\nnhap sai kieu du lieu. Vui long nhap lai!");
        }
      }
    }

    // Ham xuat phan so
    public void Xuat()
    {
      Console.Write(" {0}/{1}", Tu, Mau);
    }
    // public void KiemTraPhanSo()
    // {
    //   double a = (double)Tu / Mau;
    //   Console.Write("{0}  ", a);
    //   if (a > 0)
    //     Console.Write("\n la phan so duong:");
    //   if (a < 0)
    //     Console.Write("\nla phan so am:");
    //   if (a == 0)
    //     Console.Write("\nphan so bang khong:");
    // }

    // Tim UCLN
    static int UCLN(int a, int b)
    {
      if (a < 0)
        a *= -1;
      if (b < 0)
        b *= -1;
      while (a != b)
      {
        if (a > b)
        {
          a -= b;
        }

        if (a < b)
        {
          b -= a;
        }

      }
      return a;
    }
    public void RutGonPhanSo()
    {
      // int tam = new int();
      int tam = UCLN(Tu, Mau);
      Tu = Tu / tam;
      Mau = Mau / tam;
    }
    public PhanSo TinhTong(PhanSo a)
    {
      PhanSo n = new PhanSo();
      n.Tu = Tu * a.Mau + a.Tu * Mau;
      n.Mau = Mau * a.Mau;
      return n;
    }
    public PhanSo TinhHieu(PhanSo a)
    {
      PhanSo n = new PhanSo();
      n.Tu = Tu * a.Mau - a.Tu * Mau;
      n.Mau = Mau * a.Mau;
      return n;
    }
    public PhanSo TinhTich(PhanSo a)
    {
      PhanSo n = new PhanSo();
      n.Tu = Tu * a.Tu;
      n.Mau = Mau * a.Mau;
      return n;
    }
    public PhanSo TinhThuong(PhanSo a)
    {
      PhanSo n = new PhanSo();
      n.Tu = Tu * a.Mau;
      n.Mau = Mau * a.Tu;
      return n;
    }
  }
}