using System;

namespace JenkinService
{
    public class PrimeService
    {
        public bool IsPrime(int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;

            for (int i = 2; i <= Math.Ceiling(Math.Sqrt(number)); ++i)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
    }
}
