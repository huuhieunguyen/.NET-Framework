using System;
using System.Text;

namespace Lab1_Homework
{
  class Cau3
  {
    public static void Main()
    {
      Console.OutputEncoding = Encoding.UTF8;
      int n;
      do
      {
        Console.WriteLine("Nhập vào số nguyên dương n: ");
        n = Convert.ToInt32(Console.ReadLine());
        if (n <= 0)
        {
          Console.WriteLine("Vui lòng nhập số nguyên dương!");
          n = Convert.ToInt32(Console.ReadLine());
        }
      } while (n <= 0);

      Console.WriteLine("Ước của số nguyên dương n gồm: ");
      for (int i = 1; i <= n; i++)
      {
        if (n % i == 0)
        {
          Console.Write(i + "\t");
        }
      }
    }
  }
}