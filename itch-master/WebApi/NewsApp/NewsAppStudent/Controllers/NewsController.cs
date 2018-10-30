using System;
using Microsoft.AspNetCore.Mvc;
using NewsApp.Models;

namespace NewsApp.Controllers
{
    [Route("api/news")]
    public class NewsController : Controller
    {
        private NewsRepository _newsRepository;

        public NewsController(NewsRepository newsRepository)
        {
            _newsRepository = newsRepository;
        }

        [HttpPost("seed")]
        public IActionResult Seed()
        {
            throw new NotImplementedException();
        }

        [HttpPost("recreate")]
        public IActionResult RecreateDatabase()
        {
            throw new NotImplementedException();
        }

        [HttpGet("count")]
        public IActionResult Count()
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            throw new NotImplementedException();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public IActionResult Add([FromBody]News news)
        {
            _newsRepository.Add(news);
            return Ok(news.Id);
        }

        [HttpPut]
        public IActionResult Update([FromBody]News news)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Remove(int id)
        {
            throw new NotImplementedException();
        }

    }
}
