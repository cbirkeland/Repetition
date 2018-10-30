// Syfte: Visa hur frontend och backend hänger ihop. Hur man hanterar olika svar från servern och uppdaterar GUI't

using System;
using Microsoft.AspNetCore.Mvc;

namespace SquareRootApp.Controllers
{
    public class SquareRootController : Controller
    {
        [HttpGet]
        [Route("api/squareroot")]
        public IActionResult SquareRoot(int? number)
        {
            if (number == null)
            {
                return BadRequest("Didn't get any number");
            }

            if (number < 0)
            {
                return BadRequest("Can't square root negative numbers");
            }

            return Ok(Math.Sqrt((int)number));
        }
    }
}
