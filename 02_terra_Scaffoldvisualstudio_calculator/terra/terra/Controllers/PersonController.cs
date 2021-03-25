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
    public class calculatorController : ControllerBase
    {

        private readonly ILogger<calculatorController> _logger;
        private bool isnumber;

        public calculatorController(ILogger<calculatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet("sum/{firstnumber}/{secondnumber}")]
        public IActionResult sum(string firstnumber, string secondnumber)
        {
            if (isnumeric(firstnumber) && isnumeric(secondnumber)) 
            {
                var sum = converttodecimal(firstnumber) + converttodecimal(secondnumber);
                return Ok(sum.ToString());
            }
            return BadRequest("Invalid input");
        }

        [HttpGet("subtraction/{firstnumber}/{secondnumber}")]
        public IActionResult subtraction(string firstnumber, string secondnumber)
        {
            if (isnumeric(firstnumber) && isnumeric(secondnumber))
            {
                var sum = converttodecimal(firstnumber) - converttodecimal(secondnumber);
                return Ok(sum.ToString());
            }
            return BadRequest("Invalid input");
        }

        [HttpGet("mean/{firstnumber}/{secondnumber}")]
        public IActionResult mean(string firstnumber, string secondnumber)
        {
            if (isnumeric(firstnumber) && isnumeric(secondnumber))
            {
                var sum = (converttodecimal(firstnumber) + converttodecimal(secondnumber)) / 2;
                return Ok(sum.ToString());
            }
            return BadRequest("Invalid input");
        }

        [HttpGet("multiplication/{firstnumber}/{secondnumber}")]
        public IActionResult multiplication(string firstnumber, string secondnumber)
        {
            if (isnumeric(firstnumber) && isnumeric(secondnumber))
            {
                var sum = converttodecimal(firstnumber) * converttodecimal(secondnumber);
                return Ok(sum.ToString());
            }
            return BadRequest("Invalid input");
        }

        [HttpGet("division/{firstnumber}/{secondnumber}")]
        public IActionResult division(string firstnumber, string secondnumber)
        {
            if (isnumeric(firstnumber) && isnumeric(secondnumber))
            {
                var sum = converttodecimal(firstnumber) / converttodecimal(secondnumber);
                return Ok(sum.ToString());
            }
            return BadRequest("Invalid input");

        }

        [HttpGet("square-root/{firstnumber}")]
        public IActionResult squareroot(string firstnumber)
        {
            if (isnumeric(firstnumber))
            {
                var squareroot = Math.Sqrt((double)converttodecimal(firstnumber));
                return Ok(squareroot.ToString());
            }
            return BadRequest("Invalid input");
        }
        private bool isnumeric(string strnumber)
        {
            Double number;
            bool isnumber = double.TryParse(
                strnumber, 
                System.Globalization.NumberStyles.Any, 
                System.Globalization.NumberFormatInfo.InvariantInfo, 
                out number); 
            return isnumber;
        }

        private decimal converttodecimal(string strnumber)
        {
            decimal decimalvalue;
            if(decimal.TryParse(strnumber, out decimalvalue)) 
            {
                return decimalvalue;
            }
            return (0);
        }
    }
}
