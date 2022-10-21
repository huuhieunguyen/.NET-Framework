using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinhVien
{
  class SinhVien
  {
    private int maSV;
    public int maSoSV
    {
      get { return maSV; }
      set { maSV = value; }
    }

    private string hoTen;
    public string hoTenSV
    {
      get { return hoTen; }
      set { hoTen = value; }
    }

    private float diemLT;
    public float DiemLT
    {
      get { return diemLT; }
      set { diemLT = value; }
    }

    private float diemTH;
    public float DiemTH
    {
      get { return diemTH; }
      set { diemTH = value; }
    }


    public SinhVien()
    {
      this.maSV = 0;
      this.diemLT = 0;
      this.diemLT = 0;
      this.hoTen = "";
    }
    public SinhVien(int maSV, string ten, float diemLT, float diemTH)
    {
      this.maSV = maSV;
      this.diemLT = diemLT;
      this.diemLT = diemTH;
      this.hoTen = ten;
    }

    // Tính điểm trung bình
    public float tinhTB()
    {
      return (this.diemLT + this.diemTH) / 2;
    }

    public override string ToString()
    {
      return $"Mã: {maSV}\t Tên: {hoTen}\t Điểm LT: {diemLT}\t Điểm TH: {diemTH}\t ĐTB: {tinhTB()}";
    }

  }

  public class Students<T>
  {
    private List<T> _listStudent = new List<T>();

    public void Add(T person)
    {
      _listStudent.Add(person);
    }
    public void Display()
    {
      foreach (T obj in _listStudent)
      {
        Console.WriteLine($"{obj}");
      }
    }
  }

  class Program
  {
    public static void Main()
    {
      Console.OutputEncoding = Encoding.UTF8;

      Students<SinhVien> sv = new Students<SinhVien>();
      sv.Add(new SinhVien { maSoSV = 1001, hoTenSV = "Ted", DiemLT = 8, DiemTH = 8 });
      sv.Add(new SinhVien { maSoSV = 1002, hoTenSV = "Minh", DiemLT = 10, DiemTH = 7 });
      sv.Add(new SinhVien { maSoSV = 1003, hoTenSV = "Mike", DiemLT = 9, DiemTH = 7.5f });
      sv.Add(new SinhVien { maSoSV = 1004, hoTenSV = "Goo", DiemLT = 5, DiemTH = 7.5f });
      sv.Add(new SinhVien { maSoSV = 1005, hoTenSV = "Meo", DiemLT = 10, DiemTH = 5.5f });


      Console.WriteLine("Thông tin Student:");
      sv.Display();
    }
  }
}