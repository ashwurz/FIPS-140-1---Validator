using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Criptografia
{
    public class MonoBitTest
    {
        public MonoBitTest()
        {

        }

        public bool Validate(string binarystring)
        {
            //string binarystring = string.Join(string.Empty,
            //  key.Select(
            //    c => Convert.ToString(Convert.ToInt32(c.ToString(), 16), 2).PadLeft(4, '0')
            //  )
            //);

            int count = 0;
            for(int i = 0; i < 20000; i++)
            {
                if(binarystring[i] == '1')
                {
                    count++;
                }
            }

            if(count > 9654 && count < 10346)
            {
                return true;
            }

            return false;
        }
    }
}
