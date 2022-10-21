using System;

namespace Lab1_Homework
{
  class Cau2
  {
    static void RutGon(int x, int y)
    {
      int d;
      d = UCLN(x, y);

      x = x / d;
      y = y / d;

      Console.WriteLine("x/y = " + x + "/" + y);
    }

    static int UCLN(int tu, int mau)
    {
      int i, j, ucln = 1;

      if (mau < 0 && tu != 0)
      {
        tu *= -1;
        mau *= -1;
      }

      if (tu < 0)
      {
        tu *= -1;
      }

      j = (tu < mau) ? tu : mau;
      for (i = 1; i <= j; i++)
      {
        if (tu % i == 0 && mau % i == 0)
        {
          ucln = i;
        }
      }
      return ucln;
    }

    public static void Main()
    {
      Console.WriteLine("Nhap tu so: ");
      int x = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Nhap mau so: ");
      int y = Convert.ToInt32(Console.ReadLine());

      if (y == 0)
      {
        Console.WriteLine("Phan so khong hop le!");
        Console.ReadKey();
      }

      if (y != 0)
      {
        if (x == 0)
        {
          Console.WriteLine("Phan so bang 0");
          Console.ReadKey();
        }
        // else if (y < 0 && x != 0)
        // {
        //   x *= -1;
        //   y *= -1;
        //   Console.WriteLine("Phan so sau khi rut gon la: ");
        //   RutGon(x, y);
        // }
        // else if (y > 0 && x != 0)
        // {
        //   Console.WriteLine("Phan so sau khi rut gon la: ");
        //   RutGon(x, y);
        // }
        else
        {
          Console.WriteLine("Phan so sau khi rut gon la: ");
          RutGon(x, y);
        }
      }
    }
  }
}
