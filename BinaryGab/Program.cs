using System;
using System.Linq;

namespace BinaryGab  //Find longest sequence of zeros in binary representation of an integer.
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution(9));
        }
        public static int solution(int N)
        {
            string binary = "";
            while (N > 1)
            {
                binary += (N % 2).ToString();
                N = N / 2;
            }
            binary += N.ToString();
            binary = new String(binary.Reverse().ToArray());
            string[] split = binary.Split("1");
            int result = 0;
            if (split.Length >= 3)
            {
                result = split.Max(i => i.Length);

            }
            Console.WriteLine("Binary : " + binary);
            return result;
        }
    }
}
