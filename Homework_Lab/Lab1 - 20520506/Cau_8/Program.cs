using System;
using System.Text;

namespace Lab1_Homework
{
  class Cau8
  {
    struct ToaDo
    {
      public double x, y;
    }
    static void NhapToaDo(out ToaDo triangle)
    {
      Console.Write("Nhap tung do: ");
      triangle.x = Convert.ToDouble(Console.ReadLine());
      Console.Write("Nhap vi do: ");
      triangle.y = Convert.ToDouble(Console.ReadLine());
    }

    static void XuatDiem(ToaDo td)
    {
      Console.WriteLine($"({td.x},{td.y})");
    }

    static double TinhCanh(ToaDo triangle_1, ToaDo triangle_2)
    {
      return Math.Sqrt((triangle_2.x - triangle_1.x) * (triangle_2.x - triangle_1.x) + (triangle_2.y - triangle_1.y) * (triangle_2.y - triangle_1.y));
    }

    public static void Main()
    {
      ToaDo td1 = new ToaDo();
      Console.WriteLine("**********************************");
      Console.WriteLine(" Nhap toa do diem A: ");
      NhapToaDo(out td1);
      XuatDiem(td1);

      ToaDo td2 = new ToaDo();
      Console.WriteLine("**********************************");
      Console.WriteLine(" Nhap toa do diem B: ");
      NhapToaDo(out td2);
      XuatDiem(td2);

      ToaDo td3 = new ToaDo();
      Console.WriteLine("**********************************");
      Console.WriteLine(" Nhap toa do diem B: ");
      NhapToaDo(out td3);
      XuatDiem(td3);

      // NhapThongTinSinhVien(out SV1);
      Console.WriteLine("**********************************");
      Console.WriteLine(" Do dai 3 canh la: ");
      // XuatThongTinSinhVien(SV1);
      double c1 = TinhCanh(td1, td2);
      double c2 = TinhCanh(td1, td3);
      double c3 = TinhCanh(td2, td3);
      Console.WriteLine(c1 + "\n" + c2 + "\n" + c3);

      Console.WriteLine("**********************************");
      Console.WriteLine($"Chu vi tam giac: {c1 + c2 + c3}");
      // Tính nửa chu vi
      double p = (c1 + c2 + c3) / 2;
      //Tính diện tích tam giác
      double S = Math.Sqrt(p * (p - c1) * (p - c2) * (p - c3));
      Console.WriteLine($"Dien tich tam giac: {S}");

      Console.ReadLine();
    }
  }
}