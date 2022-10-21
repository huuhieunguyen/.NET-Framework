using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IV_P1_Cau3{
class Xe
    {
        private int dungTich;
        private double triGia;
        private string tenChuXe, loaiXe;

        public string LoaiXe
        {
            get { return loaiXe; }
            set { loaiXe = value; }
        }

        public int DungTich
        {
            get { return dungTich; }
            set { dungTich = value; }
        }

        public double TriGia
        {
            get { return triGia; }
            set { triGia = value; }
        }

        public string TenChuXe
        {
            get { return tenChuXe; }
            set { tenChuXe = value; }
        }

        public Xe()
        {
            this.loaiXe = "";
            this.dungTich = 0;
            this.triGia = 0;
            this.tenChuXe = "";
        }

        public Xe(string loaiXe, int dungTich, double triGia, string tenChuXe)
        {
            this.loaiXe = loaiXe;
            this.dungTich = dungTich;
            this.triGia = triGia;
            this.tenChuXe = tenChuXe;
        }

        public double tienThue()
        {
            double thue = 0;

            if(this.dungTich < 100)
            {
                thue = this.triGia * 0.01;
            }
            else if (this.dungTich >= 100 && this.dungTich < 175)
            {
                thue = this.triGia * 0.03;
            }
            else if (this.dungTich >= 175)
            {
                thue = this.triGia * 0.05;
            }

            return thue;
        }

        public void Nhap()
        {
            // Xe x = new Xe();

            Console.WriteLine("===========Nhập thông tin xe==============");
            Console.WriteLine("Nhập tên chủ xe: ");
            tenChuXe = Console.ReadLine();

            if(tenChuXe == null)
            {
                Console.WriteLine("Kết thúc nhập thông tin!");
                return;
            }

            Console.WriteLine("Nhập loại xe: ");
            loaiXe = Console.ReadLine();

            Console.WriteLine("Nhập dung tích xe: ");
            dungTich = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Nhập trị giá xe: ");
            triGia = double.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.WriteLine("=========== Thông tin xe ===========");
            Console.WriteLine($"Chủ xe: " + this.tenChuXe);
            Console.WriteLine($"Loại xe: " + this.loaiXe);
            Console.WriteLine($"Trị giá xe: " + this.triGia);
            Console.WriteLine($"Dung tích: " + this.dungTich);
            Console.WriteLine($"Thuế phải đóng: " + this.tienThue());
        }
    }
}