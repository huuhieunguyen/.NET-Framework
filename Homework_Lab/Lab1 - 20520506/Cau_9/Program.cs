using System;
using System.Text;

namespace Lab1_Homework
{
  class Cau9
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

      Console.WriteLine("Số chữ số có trong n là: " + n.ToString().Length);
    }
  }
}