using System;

namespace Lab1_Homework
{
  class Cau10
  {
    public static string HundresToWords(string str_n)
    {
      string kq = "";
      string[] a = { "khong ", "mot ", "hai ", "ba ", "bon ", "nam ", "sau ", "bay ", "tam ", "chin " };
      int l = str_n.Length;
      int i = 0;
      if (l == 3)
      {
        if (str_n.Equals("000"))
        {
          return kq;
        }
        kq += a[int.Parse(str_n.Substring(i, 1))] + "tram ";
        i++;
        if (str_n.Substring(1, 2).Equals("00"))
        {
          return kq;
        }
      }
      if (l >= 2)
      {
        if (int.Parse(str_n.Substring(i, 1)) == 0)
        {
          kq += "le ";
        }
        else if (int.Parse(str_n.Substring(i, 1)) == 1)
        {
          kq += "muoi ";
          a[5] = "lam ";
        }
        else
        {
          kq += a[int.Parse(str_n.Substring(i, 1))] + "muoi ";
          a[5] = "lam ";
        }
        i++;
      }
      if (int.Parse(str_n.Substring(i, 1)) != 0)
        kq += a[int.Parse(str_n.Substring(i, 1))];
      return kq;
    }
    public static string NumberToWords(int n)
    {
      string[] b = { "", "nghin ", "trieu ", "ty " };
      string kq = "";
      string str_n = n.ToString();
      int l = str_n.Length;
      int i = 0;
      while ((i + 1) * 3 < l)
      {
        if (HundresToWords(str_n.Substring(l - (i + 1) * 3, 3)).Equals(""))
          kq += "";
        else
          kq = HundresToWords(str_n.Substring(l - (i + 1) * 3, 3)) + b[i] + kq;
        i++;
      }
      if (i != 0)
      {
        kq = HundresToWords(str_n.Substring(0, l - i * 3)) + b[i] + kq;
      }
      else
      {
        kq = HundresToWords(str_n.Substring(0, l)) + kq;
      }
      return kq;
    }
    static void Main(string[] args)
    {
      int n;
      do
      {
        Console.Write("Nhap so nguyen duong n: ");
        n = Convert.ToInt32(Console.ReadLine());
        if (n < 0)
        {
          Console.Write("n phai >= 0. Vui long nhap lai so nguyen duong n: ");
          n = Convert.ToInt32(Console.ReadLine());
        }
      } while (n <= 0);

      Console.WriteLine($"=> Cach doc: {NumberToWords(n)}");
    }
  }
}
