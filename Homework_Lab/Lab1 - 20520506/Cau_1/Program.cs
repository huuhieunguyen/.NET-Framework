using System;

namespace Lab1_Homework
{
  class Cau1
  {
    public static void Main()
    {
      int i, n1, n2, j, ucln = 1;
      Console.Write("\n");
      Console.WriteLine("Tim uoc so chung lon nhat:");
      Console.WriteLine("-----------------------------------");

      Console.Write("Nhap so thu nhat: ");
      n1 = Convert.ToInt32(Console.ReadLine());
      Console.Write("Nhap so thu hai: ");
      n2 = Convert.ToInt32(Console.ReadLine());
      j = (n1 < n2) ? n1 : n2;
      for (i = 1; i <= j; i++)
      {
        if (n1 % i == 0 && n2 % i == 0)
        {
          ucln = i;
        }
      }
      Console.WriteLine("\nUCLN cua {0} va {1} la: {2}", n1, n2, ucln);
      Console.ReadKey();
    }
  }
}