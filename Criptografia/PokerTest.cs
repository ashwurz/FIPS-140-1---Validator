using System;
using System.Collections.Generic;
using System.Text;

namespace Criptografia
{
    public class PokerTest
    {
        public PokerTest()
        {

        }

        public bool Validate(string binarystring)
        {
            int[] count = new int[16];
            int countTotal = 0;
            for (int i = 0; i < 16; i++)
            {
                count[i] = 0;
            }
            for (int i = 0; i < 20000; i += 4)
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append($"{binarystring[i]}");
                stringBuilder.Append($"{binarystring[i + 1]}");
                stringBuilder.Append($"{binarystring[i + 2]}");
                stringBuilder.Append($"{binarystring[i + 3]}");
                int number = Convert.ToInt32(Convert.ToString(stringBuilder), 2);
                count[number]++;
            }

            for (int i = 0; i < 16; i++)
            {
                countTotal += Convert.ToInt32(Math.Pow(count[i], 2));
            }

            double x = (16.0 / 5000.0) * (countTotal * 1.0) - 5000.0;

            if (x > 1.03 && x < 57.4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
