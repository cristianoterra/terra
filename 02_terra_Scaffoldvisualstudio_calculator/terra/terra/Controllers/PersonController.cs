using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace terra.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class personController : ControllerBase
    {

        private readonly ILogger<personController> _logger;
        private bool isnumber;

        public personController(ILogger<personController> logger)
        {
            _logger = logger;
        }

        [HttpGet("subtraction/{firstnumber}/{secondnumber}")]
        public IActionResult subtraction(string firstnumber, string secondnumber)
        { 
            return BadRequest("Invalid input");
        }
    }
}
