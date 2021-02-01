using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGB_Hexadecimal
{
    class Program
    {
        static int hexDivider = 16; 

        public static string Convert(int num)
        {
            string hexNumber = num.ToString("X");

            return hexNumber;
        }

        public static string RGB(int r, int g, int b)
        {
            string res = string.Empty;

            var list = new List<int>();

            list.Add(r);
            list.Add(g);
            list.Add(b);

            for (int i = 0; i < list.Count; i++)
            {
                int first = list[i] / hexDivider;
                res += Convert(first);
                int second = list[i] % hexDivider;
                res += Convert(second);
            }

            return res;
        }
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(',').Select(int.Parse).ToArray();

            if (input.Length != 3)
            {
                throw new Exception("Input should be valid.");
            }
            int r = input[0];
            int g = input[1];
            int b = input[2];

            Console.WriteLine(RGB(r,g,b));
        }
    }
}
