using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
  public class Cau3
  {
    public static void Retired_Age()
    {
      Console.WriteLine("Nhap ten: ");
      string name = Console.ReadLine();

      Console.WriteLine("Nhap gioi tinh: ");
      // 0 hoac False la Nu, 1 hoac True la Nam
      string gender = Console.ReadLine();
      do
      {
        if (gender.ToUpper() != "NAM" && gender.ToUpper() != "NU")
        {
          Console.WriteLine("Gioi tinh khong phu hop. Vui long nhap lai!");
          gender = Console.ReadLine();
        }
      } while (gender.ToUpper() != "NAM" && gender.ToUpper() != "NU");

      Console.WriteLine("Nhap ngay sinh: ");
      int date = int.Parse(Console.ReadLine());
      Console.WriteLine("Nhap thang sinh: ");
      int month = int.Parse(Console.ReadLine());
      Console.WriteLine("Nhap nam sinh: ");
      int year = int.Parse(Console.ReadLine());

      DateTime dob = new DateTime(year, month, date);
      DateTime retired_date = new DateTime();

      if (gender.ToUpper() == "NAM")
      {
        retired_date = dob.AddYears(60);
      }
      if (gender.ToUpper() == "NU")
      {
        retired_date = dob.AddYears(55);
      }
      Console.WriteLine("Ngay ve huu la: ");
      Console.WriteLine(retired_date);
    }
  }
}