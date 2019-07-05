using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6_primes
{
    class TestPrime
    {
        public static bool IsPrime(int intPrimeTest)
        {
            if (intPrimeTest <= 1)
                return false;

            else if (intPrimeTest < 4)
            {
                return true;
            }

            else if (intPrimeTest % 2 == 0)
            {
                return false;
            }

            else
            {
                int k = 3;
                int j = 1;

                do
                {
                    j = intPrimeTest % k;
                    k += 2;
                }
                while ((k <= Math.Sqrt(intPrimeTest)) && (j != 0));

                if (j == 0)
                {
                    return false;
                }

                else
                {
                    return true;
                }
            }
        }

        public static List<int> PrimesUpTo(int upTo)
        {
            bool primeBool;
            var primeList = new List<int>();

            for (int i = 0; i <= upTo; i++)
            {
                primeBool = IsPrime(i);
                if (primeBool == true)
                {
                    primeList.Add(i);
                }
            }
            return primeList;
        }
    }
}
