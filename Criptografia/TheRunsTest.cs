using System;
using System.Collections.Generic;
using System.Text;

namespace Criptografia
{
    public class TheRunsTest
    {
        public TheRunsTest()
        {

        }

        public bool Validate(string binarystring)
        {
            int countZero = 0;
            int countUm = 0;
            int[] countZeroVetor = new int[6];
            int[] countUmVetor = new int[6];
            for (int i = 0; i < 20000; i++)
            {
                if (binarystring[i] == '0')
                {
                    countZero++;
                    if (i > 0 && countUm > 0)
                    {
                        if (countUm > 6)
                        {
                            countUmVetor[5]++;
                        }
                        else
                        {
                            countUmVetor[countUm - 1]++;
                        }
                    }
                    countUm = 0;
                }
                else
                {
                    countUm++;
                    if (i > 0 && countZero > 0)
                    {
                        if (countZero > 6)
                        {
                            countZeroVetor[5]++;
                        }
                        else
                        {
                            countZeroVetor[countZero - 1]++;
                        }
                    }
                    countZero = 0;
                }
            }
            if (countZeroVetor[0] > 2267 && countZeroVetor[0] < 2733 && countZeroVetor[1] > 1079 && countZeroVetor[1] < 1421
                && countZeroVetor[2] > 502 && countZeroVetor[2] < 748 && countZeroVetor[3] > 223 && countZeroVetor[3] < 402
                && countZeroVetor[4] > 90 && countZeroVetor[4] < 223 && countZeroVetor[5] > 90 && countZeroVetor[5] < 223
                && countUmVetor[0] > 2267 && countUmVetor[0] < 2733 && countUmVetor[1] > 1079 && countUmVetor[1] < 1421
                && countUmVetor[2] > 502 && countUmVetor[2] < 748 && countUmVetor[3] > 223 && countUmVetor[3] < 402
                && countUmVetor[4] > 90 && countUmVetor[4] < 223 && countUmVetor[5] > 90 && countUmVetor[5] < 223)
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