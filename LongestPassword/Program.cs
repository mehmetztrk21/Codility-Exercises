using System;
using System.Collections.Generic;
using System.Linq;

namespace LongestPassword
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution("test 5 a0A pass007 ?xy1"));
        }

        public static int solution(string S)
        {
            string[] pass_list = S.Split(" ");
            List<int> pass_length = new List<int>();
            int count_letter = 0, count_num = 0;
            foreach (var pass in pass_list)
            {
                foreach (var c in pass)
                {

                    if (Char.IsLetter(c))
                    {
                        count_letter++;
                    }
                    else if (Char.IsDigit(c))
                    {
                        count_num++;
                    }
                    else
                    {
                        break;
                    }

                }
                if (count_letter + count_num == pass.Length && (count_letter % 2 == 0 && count_num % 2 != 0))
                {
                    pass_length.Add(count_num + count_letter);
                }
                count_letter = 0;
                count_num = 0;
            }
            if (pass_length.Count != 0)
            {
                return pass_length.Max();
            }

            return -1;
        }
    }
}
