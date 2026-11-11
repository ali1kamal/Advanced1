using System;
using System.Collections.Generic;
using System.Text;

namespace advanced1
{
    public class Swap
    {
        public void Swaping<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
