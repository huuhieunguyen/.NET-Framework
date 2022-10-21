using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V_Cau2
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

    }
  }

}