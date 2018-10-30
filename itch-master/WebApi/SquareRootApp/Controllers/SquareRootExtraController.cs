// Syfte: Extrauppgift till SquareRoot

using System;
using Microsoft.AspNetCore.Mvc;

namespace SquareRootApp.Controllers
{
    public class SquareRootExtraController : Controller
    {
        [HttpGet]
        [Route("api/squarerootextra")]
        public IActionResult SquareRoot(int? number, int? nrOfDigits)
        {
            if (number == null)
            {
                return BadRequest("Enter a number");
            }

            if (nrOfDigits == null)
            {
                return BadRequest("Enter number of digits");
            }

            if (nrOfDigits <0)
            {
                return BadRequest("Number of digits must be greater than 0");
            }

            if (number < 0)
            {
                return BadRequest("Can't square root negative numbers");
            }

            double result = Math.Sqrt((int) number);
            result = Math.Round(result, (int)nrOfDigits);
            return Ok(result);
        }
    }
}
