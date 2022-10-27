//lerissa lazar
//10-26-22
//odd or even
//user will input two numebers and the web api will say if its even or odd
//peer review: Jasmine Leek - clean, simple code that runs perfectly when inputting both odd and even numbers. nice work!


using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LazarL_MiniChOddOrEven.Controllers
{
    [Route("[controller]")]
    public class OddOrEven : Controller
    {
        [HttpGet]
        [Route("OddEven/{num}")]
        public string OddEven(int num)
        {
            int remainder = num % 2;

            if (remainder == 0)
            {
                return $"{num} is an even number";
            }
            else 
            {
                return $"{num} is an odd number";
            }
        }
    }
}