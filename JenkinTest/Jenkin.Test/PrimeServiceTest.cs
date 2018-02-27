using JenkinService;
using System;
using Xunit;

namespace Jenkin.Test
{
    public class PrimeServiceTest
    {
        private readonly PrimeService _primeService;

        public PrimeServiceTest()
        {
            _primeService = new PrimeService();
        }

        [Fact]
        public void ReturnFalseGivenValueOf1()
        {
            var result = _primeService.IsPrime(1);

            Assert.False(result, "1 should not be prime");
        }

        [Fact]
        public void ReturnTrueGivenValueOf2()
        {
            var result = _primeService.IsPrime(2);

            Assert.True(result, "2 should be prime");
        }

        [Fact]
        public void ReturnTrueGivenValueOf3()
        {
            var result = _primeService.IsPrime(3);

            Assert.True(result, "3 should be prime");
        }
    }
}
