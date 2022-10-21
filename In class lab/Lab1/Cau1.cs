using System;

namespace Lab1
{
  public class Cau1
  {
    public static void Cal_Circle()
    {
      Console.WriteLine("Nhap ban kinh r > 0: ");
      double r = Convert.ToDouble(Console.ReadLine());
      do
      {
        if (r <= 0)
        {
          Console.WriteLine("Ban kinh duong tron phai duong. Vui long nhap lai: ");
          r = Convert.ToDouble(Console.ReadLine());
        }

      } while (r <= 0);

      float p = (float)(2 * Math.PI * r);
      Console.WriteLine($"Chu vi duong tron ban kinh {r} la {p}");
    }
  }
}