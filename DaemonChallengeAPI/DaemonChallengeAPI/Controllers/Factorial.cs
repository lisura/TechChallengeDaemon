using DaemonChallengeAPI.DTO;
using DaemonChallengeAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace DaemonChallengeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Factorial : ControllerBase
    {
        // GET: api/<Factorial>
        [HttpGet]
        public string Get(int number)
        {
            var factorial = FactorialCalculator.Calculate(number);
            return JsonSerializer.Serialize(new FactorialDTO() { Result = factorial }); ;
        }

        // GET api/<Factorial>/5
        [HttpGet("{number}")]
        public string GetFromURL(int number)
        {
            return Get(number);
        }
    }
}
