using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Infoblox_Calculator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArithmeticController : ControllerBase
    {
        // GET api/arithmetic
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Welcome to my simple arithmetics calculator";
        }

        // GET api/arithmetic/add/5/4
        [HttpGet("[action]/{variableOne}/{variableTwo}")]
        public IActionResult Add(int variableOne, int variableTwo)
        {
            return Ok(variableOne + variableTwo);
        }

        // GET api/arithmetic/subtract/5/4
        [HttpGet("[action]/{variableOne}/{variableTwo}")]
        public IActionResult Subtract(int variableOne, int variableTwo)
        {
            return Ok(variableOne - variableTwo);
        }
    }
}
