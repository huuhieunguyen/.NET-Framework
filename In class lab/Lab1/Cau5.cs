using System;

namespace Lab1
{
  public class Cau5
  {
    public static void Electric_Money()
    {
      Console.WriteLine("Nhap so dien: ");
      double elec_number = double.Parse(Console.ReadLine());
      double money = 0;
      if (elec_number <= 50)
      {
        money = elec_number * 2000;
      }
      else if (elec_number > 50 && elec_number <= 100)
      {
        money = 50 * 2000 + (elec_number - 50) * 2500;
      }
      else
      {
        money = 50 * 2000 + (elec_number - 50) * 3500;
      }
      Console.WriteLine("Tien dien phai tra: " + money);
    }
  }
}