using System;
using System.Text;

namespace Lab1_Homework
{
  class Cau5
  {
    public static void Main()
    {
      Console.OutputEncoding = Encoding.UTF8;
      int n;
      Console.WriteLine("Nhập vào số nguyên n: ");
      n = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine($"Các số lẻ từ 0-{n} là:");

      // Liệt kê các số lẻ nếu n < 0
      if (n < 0)
      {
        for (int i = n; i <= 0; i++)
        {
          if (i % 2 != 0)
          {
            Console.Write(i + "\t");
          }
        }
      }

      // Liệt kê các số lẻ nếu n > 0
      for (int i = 0; i <= n; i++)
      {
        if (i % 2 != 0)
        {
          Console.Write(i + "\t");
        }
      }
    }
  }
}