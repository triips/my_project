using System;

namespace JenkinService
{
    public class PrimeService
    {
        public bool IsPrime(int candidate)
        {
            if (candidate == 1)
            {
                return false;
            }

            return true;
        }
    }
}
