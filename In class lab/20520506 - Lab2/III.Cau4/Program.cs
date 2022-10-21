using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau4
{
  public class Student
  {
    public string ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public override string ToString()
    {
      return $"Mã: {ID}\t Tên: {Name}\t Tuổi: {Age}";
    }
  }

  public class Lecturer
  {
    public string ID { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }

    public override string ToString()
    {
      return $"Mã: {ID}\t Tên: {Name}\n Lương: {Salary}";
    }
  }

  public class PersonManager<T>
  {
    private List<T> _listPerson = new List<T>();

    public void Add(T person)
    {
      _listPerson.Add(person);
    }

    public void Display()
    {
      foreach (T obj in _listPerson)
      {
        Console.WriteLine($"{obj}");
      }
    }
  }

  public class Program
  {
    public static void Main(string[] args)
    {
      Console.Title = "BTTH2";
      Console.OutputEncoding = Encoding.UTF8;

      PersonManager<Lecturer> lecturer = new PersonManager<Lecturer>();
      lecturer.Add(new Lecturer { ID = "1001", Name = "Ted", Salary = 200 });
      lecturer.Add(new Lecturer { ID = "1002", Name = "Robin", Salary = 500 });
      lecturer.Add(new Lecturer { ID = "1003", Name = "Batman", Salary = 1000 });

      PersonManager<Student> student = new PersonManager<Student>();
      student.Add(new Student { ID = "2001", Name = "King Kong", Age = 10 });
      student.Add(new Student { ID = "2002", Name = "T-Rex", Age = 15 });
      student.Add(new Student { ID = "2003", Name = "Shark", Age = 16 });

      Console.WriteLine("Thông tin Lecture:");
      lecturer.Display();
      Console.WriteLine("Thông tin Student:");
      student.Display();
    }
  }
}