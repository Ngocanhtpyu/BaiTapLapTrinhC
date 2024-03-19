using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3
{
    class Nuocgk
    {
        string tenhang;
        string dvt;
        int soluong;
        float dongia;
        public static float VAT = 0.1f;
             
                
        public string Tenhang
        {
            get { return tenhang; }
            set { tenhang = value; }
        }

        public string Dvt
        {
            get { return dvt; }
            set { dvt = value; }
        }

       

        public int Soluong
        {
            get { return soluong; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Du lieu sai"); soluong = 0;
                }
                else soluong = value;
            }
        }
        public float Dongia
        {
            get { return dongia; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Du lieu sai"); dongia = 0;
                }
                else dongia = value;
            }
        }

        public float Thanhtien()
        {
            float thanhtien = 0;
            if (dvt == "thung" || dvt == "ket")
            {
                thanhtien = soluong * dongia + soluong + dongia * VAT;
            }
            else if( dvt=="chai")
            {
                thanhtien = soluong * (dongia / 20) + soluong * (dongia / 20) * VAT;
            }
            else
            {
                thanhtien = soluong * (dongia / 24) + soluong * (dongia / 24) * VAT;

            }
            
            return thanhtien;
        }

        public void Nhap()
        {
            Console.WriteLine("Nhap vao ten hang: ");
            tenhang = Console.ReadLine();
            Console.WriteLine("Nhap vao don vi tinh: ");
            dvt = Console.ReadLine();
            Console.WriteLine("Nhap vao so luong: ");
            soluong = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap vao don gia: ");
            dongia = Convert.ToSingle(Console.ReadLine());
         

           }
        public void Xuat()
        {
            Console.WriteLine("**************************************");
            Console.WriteLine("Thong tin nuoc giai khat: ");
            Console.WriteLine("Ten hang: {0}", tenhang);
            Console.WriteLine("Don vi tinh la: {0}", dvt);
            Console.WriteLine("So luong: {0}", soluong);
            Console.WriteLine("Don gia: {0}", dongia);
            Console.WriteLine("Thanh tien: {0} dong", Thanhtien());
            Console.WriteLine("**************************************");

        }




    }
}
