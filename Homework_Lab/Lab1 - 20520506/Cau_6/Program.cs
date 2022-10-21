using System.Globalization;
using System;
using System.Text;

namespace Lab1_Homework
{
  class Cau6
  {
    public static void Main()
    {
      Console.OutputEncoding = Encoding.UTF8;

      Console.Write("Ngày: ");
      int day = Convert.ToInt32(Console.ReadLine());

      Console.Write("Tháng: ");
      int month = Convert.ToInt32(Console.ReadLine());

      Console.Write("Năm: ");
      int year = Convert.ToInt32(Console.ReadLine());

      DateTime date = new DateTime(year, month, day);

      Console.WriteLine(date);
      Console.WriteLine("----------------------");
      Console.Write("Thứ trong tuần: ");
      Console.WriteLine(date.DayOfWeek);
      Console.Write("Ngày trong năm: ");
      Console.WriteLine(date.DayOfYear);

      DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
      Calendar cal = dfi.Calendar;
      Console.Write("Tuần trong năm: ");
      Console.WriteLine("Week {1} ({2})", date, cal.GetWeekOfYear(date, dfi.CalendarWeekRule, dfi.FirstDayOfWeek), cal.ToString().Substring(cal.ToString().LastIndexOf(".") + 1));

      Console.ReadKey();
    }
  }
}