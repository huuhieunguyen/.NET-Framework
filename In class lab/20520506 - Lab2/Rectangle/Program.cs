using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
  public class HinhChuNhat
  {
    private float chieuDai;
    public float Dai { get { return chieuDai; } set { chieuDai = value; } }

    private float chieuRong;
    public float Rong { get { return chieuRong; } set { chieuRong = value; } }




    public HinhChuNhat()
    {
    }

    public HinhChuNhat(float dai, float rong)
    {
      this.Dai = dai;
      this.Rong = rong;
    }

    public float DienTich()
    {
      return Dai * Rong;
    }

    public float ChuVi()
    {
      return (Dai + Rong) * 2;
    }

    public override string ToString()
    {
      return $"Chiều dài HCN: {Dai}\t Chiều rộng HCN: {Rong}\n Chu vi HCN: {ChuVi()}\t Diện tích HCN: {DienTich()} ";
    }
  }

  public class main
  {
    public static void Main()
    {
      HinhChuNhat hcn = new HinhChuNhat();
      Console.OutputEncoding = Encoding.UTF8;

      //Console.WriteLine("Nhập chiều dài HCN: ");
      //hcn.Dai = float.Parse(Console.ReadLine());

      //Console.WriteLine("Nhập chiều rộng HCN: ");
      //hcn.Rong = float.Parse(Console.ReadLine());

      do
      {
        Console.WriteLine("Nhập chiều dài HCN: ");
        hcn.Dai = float.Parse(Console.ReadLine());

        Console.WriteLine("Nhập chiều rộng HCN: ");
        hcn.Rong = float.Parse(Console.ReadLine());
        if (hcn.Dai < hcn.Rong)
        {
          Console.WriteLine("Chiều dài phải dài hơn chiều rộng! Vui lòng nhập lại!");
        }

      } while (hcn.Dai < hcn.Rong);

      Console.WriteLine($"{hcn.ToString()}");
    }
  }

}