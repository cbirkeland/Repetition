﻿using System;
using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;
using System.Linq;

namespace WebApiLab.Controllers
{
    [Route("webapi4")]
    public class WebApi4Controller : Controller
    {
        [HttpGet("LightBulb")]
        public IActionResult LightBulb(bool light)
        {
            string backgroundColor = light? "yellow" : "#ddd";

            string html = $"<body style='background-color:{backgroundColor}'></body>";
            return Content(html, "text/html");
        }

        [HttpGet("ChocolatePieces")]
        public IActionResult ChocolatePieces(int numberOfPeople)
        {
            if (numberOfPeople <= 0)
            {
                return BadRequest($"För få personer: {numberOfPeople}");
            }

            double result = 25.0 / numberOfPeople;

            return Ok($"Varje person får {result:.##} bitar");

        }

        [HttpGet("LookupOrder")]
        public IActionResult LookupOrder(string orderId)
        {
            Match match = Regex.Match(orderId, @"^([A-Z][A-Z])-(\d{4})$", RegexOptions.IgnoreCase);

            if (!match.Success)
            {
                return BadRequest("Fel format på orderId");
            }

            string alphaPart = match.Groups[1].Value;
            int numberPart = int.Parse(match.Groups[2].Value);

            if (numberPart > 3000)
            {
                return NotFound($"Order {orderId} hittades ej");
            }

            return Ok($"Order {orderId} hittades i databasen");

        }

        [HttpGet("CheckUser")]
        public IActionResult CheckUser(string userName)
        {
            if (userName == "Stewie")
            {
                throw new Exception("DATA ERROR!");
            }

            if (userName == "Peter")
            {
                return Content("<img src='/images/explosion.jpg' />", "text/html");
            }

            string[] allowedUserNames = { "Lois", "Meg", "Chris", "Brian" };

            if (allowedUserNames.Contains(userName))
            {
                return Content("<img src='/images/thumbs-up.jpg' />", "text/html");
            }
            else
            {
                return Content("<img src='/images/thumbs-down.svg' />", "text/html");
            }
        }

    }
}