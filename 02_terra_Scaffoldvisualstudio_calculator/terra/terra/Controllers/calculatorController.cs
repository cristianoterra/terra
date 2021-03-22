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
        public IActionResult Get(string firstnumber, string secondnumber)
        {
            if (isnumeric(firstnumber) && isnumeric(secondnumber)) 
            {
                var sum = converttodecimal(firstnumber) + converttodecimal(secondnumber);
                return Ok(sum.ToString());
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
