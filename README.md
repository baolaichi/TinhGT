# Tính Giai Thừa Của 1 Số
BTVN: ASP.NET
--------------------------------------------
 ## --Thông Tin Cá nhân--
 ### Tác Giả: Lại Chí Bảo   
 ### Lớp: K57KMT.01           
 ### MSSV: K215520216829
-------------------------------------------
 
      
I. Tạo một Console Application (TinhGT):
   - Mở Visual Studio.
   - Chọn File > New > Project....
   - Chọn Console App (.NET Framework) hoặc Console App (.NET Core).
   - Đặt tên cho project là Console1 và chọn Create.
   - Viết mã để tính giai thừa:
using System;
namespace TinhGT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập một số nguyên dương để tính giai thừa:");
            if (int.TryParse(Console.ReadLine(), out int number) && number >= 0)
            {
                long result = CalculateFactorial(number);
                Console.WriteLine($"Giai thừa của {number} là: {result}");
            }
            else
            {
                Console.WriteLine("Vui lòng nhập một số nguyên dương hợp lệ.");
            }
            Console.WriteLine("Nhấn phím bất kỳ để thoát...");
            Console.ReadKey();
        }
        static long TinhGT_1(int number)
        {
            if (number == 0 || number == 1) return 1;
            long result = 1;
            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}

II. Chuyển phần xử lý sang DLL
   - Tạo một Class Library project:
   - Viết mã trong Class Library:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVGiaiThua
{
    public class TVGiaiThua
    {
        public static long TinhGT_1(int number)
        {
            if (number == 0 || number == 1) return 1;
            long result = 1;
            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
III. Console Application 2 - Sử dụng DLL
   - Tạo một project Console App (Console2)
   - Thêm tham chiếu tới DLL
   - Sử dụng DLL trong Console2:
     using System;
using TVGiaiThua;

namespace Console1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập một số nguyên dương để tính giai thừa:");
            if (int.TryParse(Console.ReadLine(), out int number) && number >= 0)
            {
                long result = TVGiaiThua.TVGiaiThua.TinhGT_1(number);
                Console.WriteLine($"Giai thừa của {number} là: {result}");
            }
            else
            {
                Console.WriteLine("Vui lòng nhập một số nguyên dương hợp lệ.");
            }
            Console.WriteLine("Nhấn phím bất kỳ để thoát...");
            Console.ReadKey();
        }
    }
}
IV. Web Application - Phiên bản 1 (Web Forms)


   
