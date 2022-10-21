using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V_Cau1
{
  struct Date
  {
    public int thang;
    public int nam;
  }

  public class DS_KhachHang<T>
  {
    private List<T> _listKH = new List<T>();

    public void Add(T customer)
    {
      _listKH.Add(customer);
    }
    // public void Display()
    // {
    //   foreach (T obj in _listKH)
    //   {
    //     Console.WriteLine($"{obj}");
    //   }
    // }

  }
  class Program
  {
    public static void Main()
    {
      Console.OutputEncoding = Encoding.UTF8;
      Date ngayHD = new Date();
      Console.WriteLine("Nhập tháng: ");
      ngayHD.thang = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Nhập năm: ");
      ngayHD.nam = Convert.ToInt32(Console.ReadLine());
    }
  }

}