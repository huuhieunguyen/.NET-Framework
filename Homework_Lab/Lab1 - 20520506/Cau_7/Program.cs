using System;
using System.Text;

namespace Lab1_Homework
{
  class Cau7
  {
    public static void Main()
    {
      Console.OutputEncoding = Encoding.UTF8;
      int day = 13, month = 1;
      int count = 0;

      Console.Write("Nhập năm: ");
      int year = Convert.ToInt32(Console.ReadLine());

      for (; month <= 12; month++)
      {
        DateTime date = new DateTime(year, month, day);
        if (date.DayOfWeek.ToString().ToUpper() == "FRIDAY")
        {
          count += 1;
        }
      }
      Console.WriteLine("----------------------");
      Console.Write($"Trong năm {year} có {count} ngày thứ 6 ngày 13.");

    }
  }
}