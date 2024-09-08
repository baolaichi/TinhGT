using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinhGT;

namespace TinhGT
{
    internal class Program
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

        // Phương thức tính giai thừa
        static long CalculateFactorial(int number)
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
