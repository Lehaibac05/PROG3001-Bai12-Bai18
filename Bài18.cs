using System.Text;

namespace Bai18
{
    internal class Program
    {



        static double ReadDouble()
        {
            double result;
            while (true)
            {
                Console.WriteLine("Nhap so thuc: ");
                if (double.TryParse(Console.ReadLine(), out result))
                {
                    return result;
                }
                Console.WriteLine("Gia tri khong hop le, xin moi nhap lai.");
            }
        }
        static void Main(string[] args)
        {
        Console.OutputEncoding = Encoding .UTF8;
            double x;
            x = ReadDouble();   
            Console.WriteLine($"Can bac hai cua {x} la: {Math.Sqrt(x)}");   
        }
    }
}
