using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw4
{
    class SuperArray
    {
        private int[] _a;
        Random rnd = new Random();

        public SuperArray(int n,int min, int max)
        {
            _a = new int[n];
            for (int i = 0; i < n; i++)
            {
                _a[i] = rnd.Next(min, max);
            }
        }

        public int Search()
        {
            int n = 0;
            for (int i = 0; i < _a.Length-1;i++)
            {
                if ((_a[i] % 3 == 0) && (_a[i+1] % 3!=0))
                {
                    n++;
                }
                if ((_a[i] % 3 != 0) && (_a[i + 1] % 3 == 0))
                {
                    n++;
                }
                Console.WriteLine(_a[i]);
            }
            return n;

        }
        
    }
}
