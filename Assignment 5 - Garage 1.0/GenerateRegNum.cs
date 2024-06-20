using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5___Garage_1._0
{
    internal class GenerateRegNum
    {

        private static readonly Random _random = new Random();

        public static string? GenerateRandomRegNum()
        {
            StringBuilder tmp = new StringBuilder();

            // Generate 3 random letters and place them in the result array
            for (int i = 0; i < 3; i++)
            {
                tmp.Append((char)('A' + _random.Next(0, 26)));
            }

            // Generate 3 random numbers and place them in the result array
            for (int i = 3; i < 6; i++)
            {
                tmp.Append((char)('0' + _random.Next(0, 10)));
            }
                string regNum = tmp.ToString();

            return regNum;
        }

        






    }

}
