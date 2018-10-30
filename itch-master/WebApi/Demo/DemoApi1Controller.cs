using System;
using Microsoft.AspNetCore.Mvc;

namespace WebApiLab.Controllers
{
    [Route("demo1")]
    public class DemoApi1Controller : Controller
    {

        [HttpGet("GetPainting")]
        public IActionResult GetPainting(string painter, DateTime paintedDate)
        {
            string response = $"Du angav konstnären {painter} och datumet {paintedDate}";
            return Ok(response);
        }

        //[HttpGet("GetPainting")]
        //public IActionResult GetPainting(PaintingRequest request)
        //{
        //    string response = $"Du angav konstnären {request.Painter} och datumet {request.PaintedDate}";
        //    return Ok(response);
        //}

        //public class PaintingRequest
        //{
        //    public string Painter { get; set; }
        //    public DateTime PaintedDate { get; set; }

        //}
    }
}