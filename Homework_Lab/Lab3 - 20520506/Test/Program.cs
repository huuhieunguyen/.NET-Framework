using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IV_P1_Cau3
{
    class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Xe[] xeList = new Xe[3];

            int n = 0;
            int a = 0;
            Boolean fl = true;

            do
            {
                Console.WriteLine("=======================");
                Console.WriteLine("Chọn chức năng: ");
                Console.WriteLine("1. Nhập thông tin");
                Console.WriteLine("2. Xuất danh sách");
                Console.WriteLine("Phím bất kì để thoát!");

                a = Int32.Parse(Console.ReadLine());

                switch (a)
                {
                    case 1:
                        do
                        {
                            xeList[n] = new Xe();
                            xeList[n].Nhap();
                            xeList[n].tienThue();
                            // xeList[n].Xuat();
                            ++n;
                        } while (n < xeList.Length);

            break;

                    case 2:
                        for (int i = 0; i < xeList.Length; i++)
                        {
                            xeList[i].Xuat();
                        }
                        break;

                    default:
                        Console.WriteLine("Kết thúc!");
                        fl = false;
                        break;

                }
            } while (fl);

    }
    }
    
}