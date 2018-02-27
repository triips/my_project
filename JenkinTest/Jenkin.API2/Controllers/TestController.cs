using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using JenkinService;

namespace Jenkin.API2.Controllers
{
    [Route("api/[controller]")]
    public class TestController : Controller
    {
        private readonly PrimeService _primeService;

        public TestController()
        {
            _primeService = new PrimeService();
        }

        // GET api/test/5
        [HttpGet("{number}")]
        public string Get(int number)
        {
            if (_primeService.IsPrime(number))
                return $"{number} is a prime number";
            return $"{number} is not a prime number";
        }
    }
}
