using Microsoft.AspNetCore.Mvc;
using WebApiLab.Models;

namespace WebApiLab.Controllers
{
    [Route("webapi6")]
    public class WebApi6Controller : Controller
    {
        [HttpPost("AddDocument")]
        public IActionResult AddDocument(Document document)
        {
            return Ok(document);
        }
        
    }
}