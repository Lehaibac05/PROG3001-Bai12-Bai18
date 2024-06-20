using System.Text;

namespace Bai16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            byte m = ReadByteInRange(2, 10);
            byte n = ReadByteInRange(2, 10);
            Console.WriteLine($"Giá trị đã nhập: m = {m}, n = {n}");

            int[,] array = new int[m, n];

            array = Read2DArray(m, n);
            Console.Write("Mảng đã nhập là: ");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine($"{array[i, j]}");
                }
                Console.WriteLine();

                int sum = SumOfElementsDivisibleBy(array, 2024);
                Console.Write($"Tổng các phần tử chia hết cho 2024 là: {sum}");
            }

            static byte ReadByteInRange(byte min, byte max)
            {
                byte result;
                while (true)
                {
                    Console.Write($"Nhập số nguyên không dấu từ {min} đến {max}: ");
                    if (byte.TryParse(Console.ReadLine(), out result) && result >= min && result <= max)
                    {
                        return result;
                    }
                    Console.WriteLine($"Giá trị không hợp lệ. Vui lòng nhập lại.");
                }
            }


            static int ReadInt32()
            {
                int result;
                while (true)
                {
                    Console.Write("Nhập số nguyên 4 byte: ");
                    if (int.TryParse(Console.ReadLine(), out result))
                    {
                        return result;
                    }
                    Console.WriteLine($"Giá trị không hợp lệ. Vui lòng nhập lại.");
                }
            }

            static int[,] Read2DArray(int m, int n)
            {
                int[,] array = new int[m, n];
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write($"Nhập giá trị cho phần tử [{i}, {j}]: ");
                        array[i, j] = ReadInt32();
                    }
                }
                return array;
            }

            static int SumOfElementsDivisibleBy(int[,] array, int p)
            {
                int sum = 0;
                foreach (int value in array)
                {
                    if (value % p == 0)
                    {
                        sum += value;
                    }
                }
                return sum;
            }
        }
    }
}
