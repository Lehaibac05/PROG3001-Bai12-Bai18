using System.Text;

namespace Bai15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            byte n = ReadByteFromConsole();

            Console.WriteLine("Số bạn vừa nhập là: " + n);

            float[] a = new float[n];


            ReadFloatArrayFromConsole(a);

            Console.Write("Các phần tử của mảng là: ");
            foreach (float value in a)
            {
                Console.Write(value);
            }
        }

        static byte ReadByteFromConsole()
        {
            byte result;
            while (true)
            {
                Console.Write("Nhập số nguyên không dấu từ 2 đến 10: ");
                string input = Console.ReadLine();
                if (byte.TryParse(input, out result) && result >= 2 && result <= 10)
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Giá trị nhập không hợp lệ. Vui lòng nhập lại.");
                }
            }
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

        static void ReadFloatArrayFromConsole(float[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Nhập phần tử thứ {i + 1}: ");
                array[i] = ReadFloatFromConsole();
            }
        }
    }
}
