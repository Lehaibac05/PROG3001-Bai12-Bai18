using System.Text;

namespace Bai17
{
    internal class Program
    {
        static int CountWords(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return 0;

            // Tách các từ bằng các ký tự không phải là chữ và số
            char[] delimiters = new char[] { ' ', '.', ',', '!', '?', ';', ':', '-', '_', '/', '\\', '(', ')', '[', ']', '{', '}', '"', '\'' };
            string[] words = input.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }

        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập vào xâu ký tự: ");
            string st = Console.ReadLine();

            if (st == "#")
            {
                Console.Beep();
                Console.WriteLine("Bạn đã nhập dấu #.");
            }
            else
            {
                int wordCount = CountWords(st);
                Console.WriteLine($"Số từ trong xâu ký tự là: {wordCount}");
            }
        }
    }
}
