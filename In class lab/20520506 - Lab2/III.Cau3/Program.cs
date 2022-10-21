using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau_3
{
  class Cau_3
  {
    public static double GetAverage<T>(List<T> numList)
    {
      double avg = 0.0;
      foreach (var num in numList)
      {
        avg += double.Parse(num.ToString());
      }
      return avg / numList.Count;
    }

    public static void Main()
    {
      Console.OutputEncoding = Encoding.Unicode;
      List<int> listInt = new List<int> { 5, 8, 59, 9, 11, 24, 40 };
      List<float> listFloat = new List<float> { 7.9f, 13.12f, 50.56f, 109.5f, 80.4f };

      Console.WriteLine($"Trung bình cùa List int: {GetAverage(listInt)}");
      Console.WriteLine($"Trung bình cùa List float: {GetAverage(listFloat)}");
    }
  }
}
