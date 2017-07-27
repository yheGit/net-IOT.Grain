using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTest
{
    public class Comm
    {
        public static void test(int param)
        {
            //string[] arr = new string[] { "X","Z","Y"};
            int sum = param > 27 ? param : 27;
            int remainder = sum / 9;//商
            int quotient = sum % 9;//余数
            int x, y, z;
            int[] arr = new int[remainder];
            int cout = 0;
            int xCount = arr.Length, yCount = arr.Length, zCount = arr.Length;
            if (quotient > 0 && quotient <= 27)
                zCount++;
            for (x = 1; x <= xCount; x++)
            {
                for (y = 1; y <= yCount; y++)
                {
                    for (z = 1; z <= zCount; z++)
                    {
                        //z = 1;
                        Console.WriteLine("{0} {1} {2}->{3}", x, y, z, ++cout);
                    }
                }

            }


        }

    }
}
