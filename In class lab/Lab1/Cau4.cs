using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

namespace Lab1
{
  public class Cau4
  {
    public static void ChuoiXY()
    {
      Console.WriteLine("Nhap chuoi x: ");
      string x = Console.ReadLine();
      while (x == "")
      {
        Console.WriteLine("Vui long khong de trong!");
        x = Console.ReadLine();
      }

      Console.WriteLine("Nhap chuoi y: ");
      string y = Console.ReadLine();
      while (x == "")
      {
        Console.WriteLine("Vui long khong de trong!");
        x = Console.ReadLine();
      }

      // Tổng chiểu dài của chuỗi x
      int x_length = x.Length;
      Console.WriteLine("\nDo dai cua chuoi x : " + x_length);

      // Dao nguoc chuoi x
      Console.WriteLine("\n3 ky tu dau cua chuoi x: " + x.Substring(0, 3));
      string rev = null;
      for (int i = x_length - 1; i >= 0; i--)
      {
        rev += x[i];
      }
      // 3 ky tu dau cua chuoi x
      if (x_length < 3)
      {
        Console.WriteLine("Chuoi x khong co du 3 ky tu!!!");
      }
      else
      {
        Console.WriteLine("\n3 ky tu cuoi cua chuoi x: " + rev.Substring(0, 3));
      }

      // ký tự thứ 6 của chuỗi x
      if (x_length < 6)
      {
        Console.WriteLine("Chuoi x khong co du 6 ky tu!!!");
      }
      else
      {
        Console.WriteLine("\nKy tu 6 cua chuoi x: " + x.Substring(5, 1));

      }

      // Tổng chiểu dài của chuỗi y
      int y_length = y.Length;
      // Dao nguoc chuoi y
      string y_rev = null;
      for (int i = y_length - 1; i >= 0; i--)
      {
        y_rev += y[i];
        // Console.Write(y[i]);
      }
      // Tạo chuỗi mới gồm 3 kí tự đầu tiên của chuỗi x và 3 kí tự cuối của chuỗi y.
      Console.WriteLine("\n3 ky tu dau cua x + 3 ky tu cuoi cua y: " + x.Substring(0, 3) + y_rev.Substring(0, 3));

      //Kiểm tra 2 chuỗi x, y có bằng nhau hay không
      if (x.Equals(y))
      {
        Console.WriteLine("Chuoi x bang chuoi y!");
      }
      else
      {
        Console.WriteLine("Chuoi x khong bang chuoi y!");
      }

      int index = x.IndexOf(y);
      if (index != -1)
      {
        Console.WriteLine("y co xuat hien trong chuoi x va o vi tri: " + index);
      }
      else
      {
        Console.WriteLine("y khong xuat hien trong chuoi x");

      }

      // Cho biết tất cả các vị trí xuất hiện của y trong x
      bool flag = false;
      for (int i = 0; i < x.Length - y.Length + 1; i++)
      {
        if (x.Substring(i, y.Length).Equals(y))
        {
          Console.WriteLine("Cac vi tri xuat hien cua y trong x la: " + i + " ");
          flag = true;
        }
      }

      if (flag == false)
      {
        Console.WriteLine("NONE");
      }
    }
  }
}
