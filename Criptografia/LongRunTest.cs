using System;
using System.Collections.Generic;
using System.Text;

namespace Criptografia
{
    public class LongRunTest
    {
        public LongRunTest()
        {

        }

        public bool Validate(string binarystring)
        {
            int countZero = 0;
            int countOne = 0;
            for (int i = 0; i < 20000; i++)
            {
                if (binarystring[i] == '0')
                {
                    countZero++;
                    if (countZero == 34)
                    {
                        return false;
                    }
                    countOne = 0;
                }
                else
                {
                    countOne++;
                    if (countOne == 34)
                    {
                        return false;
                    }
                    countZero = 0;
                }
            }
            return true;
        }
    }
}
