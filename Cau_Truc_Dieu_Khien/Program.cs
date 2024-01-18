using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Cau_Truc_Dieu_Khien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            while (true)
            {
                int n = Nhapn();
                int m = Chonchuongtrinh(n);
                switch (m)
                {
                    case 1:
                        bai_01(n);
                        break;
                    case 2:
                        bai_02(n);
                        break;
                    case 3:
                        bai_03(n);
                        break;
                    case 4:
                        bai_04(n);
                        break;
                    case 5:
                        bai_05(n);
                        break;
                    case 6:
                        bai_06(n);
                        break;
                    case 7:
                        bai_07(n);
                        break;
                    case 8:
                        bai_08(n);
                        break;
                    case 9:
                        bai_09(n);
                        break;
                    case 10:
                        bai_10(n);
                        break;
                    
                    case 0:
                        Console.WriteLine("Bạn đã thoát chương trình");
                        break;

                }
                Console.WriteLine("*************************************************");
                char kt = TiepTuc();
                Console.Clear();
                if (char.ToUpper(kt) == 'N') break;
                else if (char.ToUpper(kt) == 'Y') continue;

            }
            int Chonchuongtrinh(int n)
            {
                Console.WriteLine("Chọn chương trình muốn thực thi ");
                Console.WriteLine("1: Kiểm tra n chia hết cho 3 hay không ?");
                Console.WriteLine("2: Nhập n hiển thị bảng cửu chương từ 1 đến n");
                Console.WriteLine("3: Tính tổng giai thừ từ 1 đến n");
                Console.WriteLine("4: Kiểm tra n có phải số chính phương hay không?");
                Console.WriteLine("5: Nhập tháng hiển thị số ngày trong tháng đó");
                Console.WriteLine("6: Tính tổng bình phương từ 1 đến n");
                Console.WriteLine("7: Tổng số lẻ từ 1 đến n");
                Console.WriteLine("8: Các số nguyên tố từ 1 đến n");
                Console.WriteLine("9: Vẽ tam giác có n hàng");
                Console.WriteLine("10: Dãy Fibonacci n phần tử");
                Console.WriteLine("0: Exit");
                Console.WriteLine("*************************************************");
                int m = int.Parse(Console.ReadLine());
                Console.WriteLine("N là " + n + " + chương trình là " + m);
                return m;

            }
            int Nhapn()
            {
                Console.WriteLine("Nhập vào số nguyên N");
                int n = int.Parse(Console.ReadLine());
                return n;
            }
            char TiepTuc()
            {
                Console.WriteLine("Bạn có muốn tiếp tục chương trình không?\n N: không \n Phím bất kì để tiếp tục");
                char check = Console.ReadKey().KeyChar;
                Console.WriteLine();
                Console.WriteLine("*************************************************");
                return check;
            }
            void bai_01(int n)
            {
                if (n % 3 == 0)
                {
                    Console.WriteLine(" Số vừa nhập là {0} và chia hết cho 3", n);
                }
                else Console.WriteLine(" Số vừa nhập là {0} và không chia hết ch0 3", n);
            }
            void bai_02(int n)
            {
                for (int i = 1; i <= n; i++)
                {
                    for(int j = 1; j<=10;j++)
                    {
                        Console.WriteLine("{0} * {1} = {2} \t", i,j, j * i);
                    }
                    Console.WriteLine();
                }
            }
            void bai_03(int n)
            {
                long tonggiaithua = 0;
                if (n > 0)
                {
                    for (int i = 1; i <= n; i++)
                    {
                        tonggiaithua = tonggiaithua + TinhGiaiThua(i);
                    }
                    Console.WriteLine("Tổng giai thừa từ 1 đến " + n + " là " + tonggiaithua);
                }

            }
            long TinhGiaiThua(int n)
            {
                if (n == 0 | n == 1)
                {
                    return 1;
                }
                else
                {
                    return n * TinhGiaiThua(n - 1);
                }
            }

            void bai_04(int n)
            {
                bool kt = false;

                for (int i = 1; i <= Math.Sqrt(n); i++)
                {
                    if (i * i == n)
                    {
                        Console.WriteLine(n + " là số chính phương");
                        kt = true;
                        break;
                    }

                }
                if (kt == false) Console.WriteLine(n + " không là số chính phương");
            }
            void bai_05(int n)
            {
                switch (n)
                {

                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        Console.WriteLine("Tháng " + n + " có 31 ngày");
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        Console.WriteLine("Tháng " + n + " có 30 ngày");
                        break;
                    case 2:
                        Console.WriteLine(" Tháng 2 có 28 hoặc 29 ngày");
                        break;
                }
            
            }
            void bai_06(int n)
            {
                long tong = 0;
                for (int i = 1; i <= n; i++)
                {

                    tong = tong + (long)Math.Pow(i, i);
                }
                Console.WriteLine("Tổng lũy thừa từ 1 đến " + n + " là " + tong);

            }
            void bai_07(int n)
            {
                long tongsole = 0;
                for(int i = 1;i<= n; i=i+2)
                {
                    tongsole += i;
                    Console.Write("{0}\t", i);
                }
                Console.WriteLine();
                Console.WriteLine("Tổng số lẻ từ 1 đến n là " + tongsole);   
            }
            void bai_08(int n)
            {
                Console.WriteLine("Các số nguyên tố từ 1 đến " + n + " là: ");
                for (int i = 2;i<= n; i++)
                {
                    if (lasonguyento(i))
                    {
                        Console.Write(i+ "\t");
                    }
                }
                Console.WriteLine();
            }
            bool lasonguyento(int i)
            {
                if (i < 2) return false;
                for( int j = 2 ; j<= Math.Sqrt(i);j++)
                {
                    if(i % j ==0)   return false;
                }  
                return true;
            }
            void bai_09(int n)
            {
                for (int i = 0; i <= n; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            void bai_10(int n)
            {
                long a = 0, b = 1, fibo;
                Console.WriteLine("Dãy Fibonacci {0} phần tử là: ", n);
                for (int i = 1; i <= n; i++)
                {
                    fibo = a + b;
                    b = a;
                    a = fibo;
                    Console.Write(fibo + "\t");
                }
                Console.WriteLine();

            }
        }
    }   
}
