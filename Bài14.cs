using System.Text;

namespace Bai14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            float x = ReadFloatFromConsole();

            Console.WriteLine("Giá trị vừa nhập: " + x);
        }

        static float ReadFloatFromConsole()
        {
            float result;
            while (true)
            {
                Console.Write("Nhập số thực 4 byte: ");
                string input = Console.ReadLine();
                if (float.TryParse(input, out result))
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Giá trị nhập không hợp lệ. Vui lòng nhập lại.");
                }
            }
        }

    }
}
