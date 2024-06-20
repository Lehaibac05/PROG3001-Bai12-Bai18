using System.Text;
using System.Threading.Channels;

namespace Bai12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            ushort n;

            n = ReadUShortFromConsole();
            Console.WriteLine("Gia tri vua nhap la: "+ n);

            long sumOfSquares = CalculateSumOfSquares(n);

            Console.WriteLine("Tong binh phuong tu 1 den " +n+ " la: "+ sumOfSquares);
        }

        static ushort ReadUShortFromConsole()
        {
            while (true)
            {
                Console.WriteLine("Nhap mot so nguyen: ");
                string input = Console.ReadLine();

                if (ushort.TryParse(input, out ushort value))
                {
                    return value;
                }   
            }
        }

        static long CalculateSumOfSquares(ushort n) { 
        long sum = 0;
            for (ushort i = 0; i < n; i++)
            {
                sum+= (long)i*i;  
            }
            return sum;
        }
    }
}
