using System.Text;

namespace Bai13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            byte n = ReadByteromConsole();
            
            Console.WriteLine("So ban vua nhap la: " + n);

        }

        static byte ReadByteromConsole()
        {
            byte result;
            while (true)
            {
                Console.WriteLine("Nhap so nguyen ko dau tu 2 den 10: ");
                string input = Console.ReadLine();
                if (byte.TryParse(input, out result) && result >= 2 && result <= 10){
                    return result;
                }
                    
                else {
                    Console.WriteLine("So khong hop le moi nhap lai.");
                }
            }
        }
    }
}
